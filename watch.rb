#!/usr/bin/env ruby

class FileItem
  attr_accessor :name,:last_changed_time

  def initialize(name)
    @name = name
    @last_changed_time = File.mtime(name)
    @was_changed = false
  end

  def has_changed?
    @last_changed_time < File.mtime(@name)
  end

  def update
    @last_changed_time = File.mtime(@name)
  end

  def was_deleted?
    not File.exists?(@name)
  end
end

all_files ={}

class ChangeResult
  attr_accessor :changes,:files
  def flag_changes
    @changes = true
  end
end


def populate_files(all_files)
  result = ChangeResult.new
  Dir.glob("**/*.cs").each do|file|
    unless (all_files.key?(file))
      result.flag_changes
      all_files[file] = FileItem.new(file)
    end
  end
  result
end

def remove_all_deleted(all_files)
  result = ChangeResult.new
  remove = {}
  all_files.each do |path,file|
    if (file.was_deleted?)
      remove[path] = file if file.was_deleted?
      result.flag_changes
    end
  end
  remove.each do|path,file|
    all_files.delete(path)
  end
  result
end

def update_files(all_files)
  result = populate_files(all_files)
  result2 = remove_all_deleted(all_files)

  return result2.changes | result.changes
end

def files_have_changed(all_files)
  has_changed = false
  all_files.each do|path,file|
    has_changed |= file.has_changed?
    file.update
  end
  return has_changed
end

def get_errors_in(output)
  error_pattern = /error|FAIL/
  output.split("\n").select{|item| error_pattern =~ item}
end


def monitor(all_files)
  if (update_files(all_files) | files_have_changed(all_files))
    errors = get_errors_in(`rake specs:run`)
    message = (errors.length == 0 ? "Build Successful" : errors.join('\n'))
    `growlnotify "#{message}"`
  end
end

while true do
  monitor(all_files)
  sleep(1)
end
