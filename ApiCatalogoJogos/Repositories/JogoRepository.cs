using ApiCatalogoJogos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private static Dictionary<Guid, Jogo> jogos = new Dictionary<Guid, Jogo>()
        {
            {Guid.Parse("nsdkflsi-1564-78w6-96fr-1235dd8a6sd18"), new Jogo{Id = Guid.Parse("nsdkflsi-1564-78w6-96fr-1235dd8a6sd18"), Nome = "Fifa 21", Produtora = "EA", Preco = 200}},
            {Guid.Parse("edf416xz-4862-er25-12we-854ffgt478sse"), new Jogo{Id = Guid.Parse("edf416xz-4862-er25-12we-854ffgt478sse"),Nome = "Fifa 20", Produtora = "EA", Preco = 190}},
            {Guid.Parse("wel48gt6-tg5j-96t6-58gh-qwertyuiopçlk"), new Jogo{Id = Guid.Parse("wel48gt6-tg5j-96t6-58gh-qwertyuiopçlk"),Nome = "Fifa 19", Produtora = "EA", Preco = 180}},
            {Guid.Parse("lhy369fb-erty-bg58-lkjj-mnbvcxzasdfgh"), new Jogo{Id = Guid.Parse("lhy369fb-erty-bg58-lkjj-mnbvcxzasdfgh"),Nome = "Fifa 18", Produtora = "EA", Preco = 170}},
            {Guid.Parse("potyu65r-erty-444j-3333-dfghjklçpoiuy"), new Jogo{Id = Guid.Parse("potyu65r-erty-444j-3333-dfghjklçpoiuy"),Nome = "Street Fighter V", Produtora = "Capcom", Preco = 80}},
            {Guid.Parse("mljou54h-rrrr-hyju-4458-cderfvbgtyhnm"), new Jogo{Id = Guid.Parse("mljou54h-rrrr-hyju-4458-cderfvbgtyhnm"),Nome = "Grand Theft Auto V", Produtora = "Rockstar", Preco = 21900}}

        };
        public Task<List<Jogo>> Obter(int pagina, int quantidade)
        {
            return Task.FromResult(jogos.Values.Skip((pagina - 1)* quantidade).Take(quantidade).ToList());
        }
        public Task<Jogo> Obter(Guid id)
        {
            if (!jogos.ContainsKey(id)) return null;
            return Task.FromResult(jogos[id]);
        }
        public Task<List<Jogo>> Obter(string nome, string produtora)
        {
            return Task.FromResult(jogos.Values.Where(jogo =>
            jogo.Nome.Equals(nome) && jogo.Produtora.Equals(produtora)).ToList());
        }
          
        public Task Inserir(Jogo jogo)
        {
            jogos.Add(jogo.Id, jogo);
            return Task.CompletedTask;
        }
        public Task Atualizar(Jogo jogo)
        {
            jogos.Add(jogo.Id, jogo);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        

        

        

        

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
