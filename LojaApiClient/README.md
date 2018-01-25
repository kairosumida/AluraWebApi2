<h1>Lado do cliente</h1>
<h2>Get</h2>
<p>
<code>

		string conteudo;
		HttpWebRequest request = (HttpWebRequest)WebRequest.Create("Endereço");
		request.Method = "GET";

		WebResponse response = request.GetResponse();
		using (Stream responseStream = response.GetResponseStream())
		{
			StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
			conteudo = reader.ReadToEnd();
		}
		</code>
</p>
<h2>Post</h2>
<p>
<code>

      string conteudo;
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create("Endereco");
      request.Method = "POST";

      string json = "Formato Json";
      byte[] jsonBytes = Encoding.UTF8.GetBytes(json);
      request.GetRequestStream().Write(jsonBytes, 0, jsonBytes.Length);

      request.ContentType = "application/json";

      WebResponse response = request.GetResponse();
      using(Stream responseStream = response.GetResponseStream())
      {
          StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
          conteudo = reader.ReadToEnd();
      }
</code>
</p>
