%w[jp].each do|name|
  system("git remote add #{name} git://github.com/#{name}/shawaugp.git")
end
