namespace :growl do
  task :start do
    system("start build/tools/growl/Growl.exe")
  end
end
