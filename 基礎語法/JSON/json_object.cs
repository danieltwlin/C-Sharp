  // Json Object Example
 JObject jObject = new JObject()
                {
                    new JProperty("jsonrpc","2.0"),
                    new JProperty("id","1"),
                    new JProperty("method","Regist"),
                    new JProperty("params",
                        new JObject()
                        {
                            new JProperty("deviceId","deviceId"),
                            new JProperty("clientId","clientId"),                            
                            new JProperty("CodeVer","CodeVer"),
                            new JProperty("productCode","productCode"),                            
                        })
                };
