configs ={
  :git => {
    :remotes => potentially_change("remotes",__FILE__),
    :repo => 'dotnet_bootcamp_prep' 
  }
}
configatron.configure_from_hash(configs)
