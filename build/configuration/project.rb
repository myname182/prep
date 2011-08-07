config = 
{
  :course_name => missing("coure_name",__FILE__),
  :project => "nothinbutdotnetprep",
  :target => "Debug",
  :source_dir => "source",
  :repo_name => missing("repo_name",__FILE__),
  :artifacts_dir => "artifacts",
  :config_dir => "source/config",
  :app_dir => "source/nothinbutdotnetprep",
  :log_file_name => "nbdn_prep.txt",
  :log_level => "DEBUG"
}
configatron.configure_from_hash config
