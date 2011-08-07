configs ={
  :git => {
    :remotes => %w[someone someoneelse jp test],
    :repo => "shawaugp"
  }
}
configatron.configure_from_hash(configs)
