<h1>Cliente</h1>
<h2>Get</h2>

<code>
	HttpWebRequest request = (HttpWebRequest)WebRequest.Create("!EndereçoAPI!");
  
    request.Method = "GET";
    WebResponse response = request.GetResponse();
    using(Stream responseStream = response.GetResponseStream())
    {
        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
        Console.Write(reader.ReadToEnd());
    }
</code>

