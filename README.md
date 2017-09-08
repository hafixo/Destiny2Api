# Destiny2Api
A core library for the Destiny 2 Api written in C# under .Net Standard 2.0. These base libraries are critical to future development of mobile, desktop, and hybrid (UWP, Xbox) applications.

# How to use it
Most of the Api endpoints are working, there are a few that don't support path based parameters. All the methods simply return a string of the current Json response. 

## Setup
You need an api key to use the BungieNet api. You can get one at https://www.bungie.net/en/Application after getting an api key you will create a `new DestinyApi(apiKey)` object and enjoy all the methods.

### Sample Api Key setup
Have a file named Keys.json in the location of the software (this should be encrpyted information in production) and use this method to retrieve the key.

  `private static String GetBungieApiKey()
  {
    var JsonData = File.ReadAllText(@"Keys.json");
    var dataModel = JsonConvert.DeserializeObject<KeyModel>(JsonData);
    return dataModel.Keys.Where(x => x.Name == "BungieNet").FirstOrDefault()?.ApiKey;
  }`

Keys.json can look something like this:
{
  "Keys": 
  [
    {
      "Name": "BungieNet",
      "ApiKey": "xxx",
      "OAuthUrl" : "https://www.bungie.net/en/OAuth/Authorize",
      "Client_id": 1234
    }
  ]
}

# Helpful Api Link
https://bungie-net.github.io/
