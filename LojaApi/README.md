
<h1>Criando Get</h1>
<h2>Modo manual</h2>
<h3>Model</h3>
<p>Criar um model para ter um objeto a ser enviado ou recebido</p>
<p>
  public class Produto(){
  
     public int Id{get;set;}
     public string Nome{get;set;}
     }
</p>
<p> Criar uma fonte de armazenamento, para guardar o produto</p>
  <p>
    public class Context(){
    
      List<Produto> Produtos{get;set;}
    }
</p>
    
<h3>Controller</h3>
<p>Criar o método Get retornando uma string</p>
<p>
      public string Get(int id){

      Context con = new Context();
      Produto p = con.Busca(id); //Este método deve buscar na lista o id especifico e retornar o objeto
      return p.ToXml(); //Recebe o xml q é uma string
      }
</p>


<h2>Modo Automatico</h2>
<p>Criar o model</p>
<p>Criar o Context e no construtor</p>
<p>  
      
      public NomeContext(DbContextOptions<NomeContext> options): base(options){}
</p>

<p>Na classe Startup</p>
<p>

    public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<NomeContext>(opt => opt.UseInMemoryDatabase("NomeContext"));//Deve-se mudar o Use InMemor.. dependendo da necessidade
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
 </p>
 <p>Agora é so usar o Scaffold para API</p>
