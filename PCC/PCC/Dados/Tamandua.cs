using PCC.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCC.Dados
{
    class Tamandua
    {
        public static IList<Animal> Tamanduas { get; private set; }

        static Tamandua()
        {
            Tamanduas = new List<Animal>();

            Tamanduas.Add(new Animal
            {
                ani_Nome = "Tamanduaí da Bolívia",
                ani_Localizacao = "Bolívia",
                ani_NomeCientifico = "Cyclopes catellus",
                ani_Descricao = "Até recentemente, acreditava-se que houvesse apenas uma espécie de tamanduaí, porém uma investigação de 10 anos realizada por Miranda et al. (2018) apontou provas de que há sete espécies de Cyclopes. Não há dados específicos disponíveis sobre o tamanho do Cyclopes catellus, mas supondo - se que tenha tamanho similar aos outros tamanduaís, teria cerca de 20 cm de comprimento de cabeça e corpo, uma cauda de comprimento similar e pesaria cerca de 300 gramas.A cor geral de sua pelagem é marrom amarelado e a cauda e as extremidades são mais amareladas.Não possui faixa escura dorsal, mas possui uma faixa ventral extensa e fortemente desenvolvida. A espécie possui uma pelagem mais densa que as demais espécies.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tamanduá",
                ani_Url = "https://www.xenarthrans.org/pt/tamanduas/tamanduai-da-bolivia/"
            });

            Tamanduas.Add(new Animal
            {
                ani_Nome = "Tamanduaí",
                ani_Localizacao = "Leste da Colômbia",
                ani_NomeCientifico = "Cyclopes didactylus",
                ani_Descricao = "Até recentemente, acreditava-se que houvesse apenas uma espécie de tamanduaí, porém uma investigação de 10 anos realizada por Miranda et al. (2018) apontou provas de que há sete espécies de Cyclopes. Este pequeno tamanduaí tem comprimento de cabeça e corpo de 20 cm, uma cauda de 16, 5 a 29, 5 cm de comprimento e pesa cerca de 300 gramas.A cor geral é amarelo pardo, com a parte traseira, patas e cauda acinzentadas.Além disso, tem uma faixa dorsal escura, irregular porém distinta, com evidentes faixas pretas dorsais e ventrais.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tamanduá",
                ani_Url = "https://www.xenarthrans.org/pt/tamanduas/tamanduai/"
            });

            Tamanduas.Add(new Animal
            {
                ani_Nome = "Tamanduáí da América Central",
                ani_Localizacao = "Sul do México",
                ani_NomeCientifico = "Cyclopes dorsalis",
                ani_Descricao = "Até recentemente, acreditava-se que houvesse apenas uma espécie de tamanduaí, porém uma investigação de 10 anos realizada por Miranda et al. (2018) apontou provas de que há sete espécies de Cyclopes. O tamanduaí da América Central tem comprimento de cabeça e corpo de 18, 5 a 21, 5cm, uma cauda de 17 a 22, 5 cm de comprimento e pesa entre 155 e 275 gramas.Sua cor é bastante diferente das outras espécies de Cyclopes: a pelagem do corpo, das extremidades e da cauda é muito amarela e há uma faixa dorsal irregular, porém, distinta e, em alguns indivíduos, uma faixa ventral pouco marcada.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tamanduá",
                ani_Url = "https://www.xenarthrans.org/pt/tamanduas/tamanduai-da-america-central/"
            });

            Tamanduas.Add(new Animal
            {
                ani_Nome = "Tamanduaí do Rio Negro",
                ani_Localizacao = "Oeste do Brasil",
                ani_NomeCientifico = "Cyclopes ida",
                ani_Descricao = "AtéAté recentemente, acreditava-se que houvesse apenas uma espécie de tamanduaí, porém uma investigação de 10 anos realizada por Miranda et al. (2018) apontou provas de que há sete espécies de Cyclopes. Não há dados específicos disponíveis sobre o tamanho do Cyclopes ida, mas supondo - se que tenha tamanho similar aos outros tamanduaís, teria cerca de 20 cm de comprimento de cabeça e corpo, uma cauda de comprimento similar e pesaria cerca de 300 gramas.A pelagem do dorso, patas e cauda é acinzentada e o ventre é amarelo. Geralmente não apresenta faixa dorsal e ventral, mas quando presente, a faixa dorsal é indistinta e se mescla à pelagem dorsal.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tamanduá",
                ani_Url = "https://www.xenarthrans.org/pt/tamanduas/tamanduai-do-rio-negro/"
            });

            Tamanduas.Add(new Animal
            {
                ani_Nome = "Tamanduaí Vermelho",
                ani_Localizacao = "Leste do Brasil",
                ani_NomeCientifico = "Cyclopes rufus",
                ani_Descricao = "Até recentemente, acreditava-se que houvesse apenas uma espécie de tamanduaí, porém uma investigação de 10 anos realizada por Miranda et al. (2018) apontou provas de que há sete espécies de Cyclopes. Não há dados específicos disponíveis sobre o tamanho do Cyclopes rufus, mas supondo-se que tenha tamanho similar aos outros tamanduaís, teria cerca de 20 cm de comprimento de cabeça e corpo, uma cauda de comprimento similar e pesaria cerca de 300 gramas. A cor de sua pelagem é única; o dorso tem um tom avermelhado distinto, enquanto a cauda e as extremidades são vermelhas amareladas. Não possui faixa ventral ou dorsal.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tamanduá",
                ani_Url = "https://www.xenarthrans.org/pt/tamanduas/tamanduai-vermelho/"
            });

            Tamanduas.Add(new Animal
            {
                ani_Nome = "Tamanduaí de Thomas",
                ani_Localizacao = "Oeste do Brasil",
                ani_NomeCientifico = "Cyclopes thomasi",
                ani_Descricao = "Até recentemente, acreditava-se que houvesse apenas uma espécie de tamanduaí, porém uma investigação de 10 anos realizada por Miranda et al. (2018) apontou provas de que há sete espécies de Cyclopes. Não há dados específicos disponíveis sobre o tamanho do Cyclopes thomasi, mas supondo-se que tenha tamanho similar aos outros tamanduaís, teria cerca de 20 cm de comprimento de cabeça e corpo, uma cauda de comprimento similar e pesaria cerca de 300 gramas. A pelagem de seu corpo é laranja vibrante a marrom avermelhado, enquanto as patas e a cauda são acinzentadas. Não possui faixa dorsal e a faixa ventral é pouco desenvolvida.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tamanduá",
                ani_Url = "https://www.xenarthrans.org/pt/tamanduas/tamanduai-vermelho/"
            });

            Tamanduas.Add(new Animal
            {
                ani_Nome = "Tamanduaí do Xingu",
                ani_Localizacao = "Região Oriental da Amazônia",
                ani_NomeCientifico = "Cyclopes xinguensis",
                ani_Descricao = "Até recentemente, acreditava-se que houvesse apenas uma espécie de tamanduaí, porém uma investigação de 10 anos realizada por Miranda et al. (2018) apontou provas de que há sete espécies de Cyclopes. Não há dados específicos disponíveis sobre o tamanho do Cyclopes xinguensis, mas supondo-se que tenha tamanho similar aos outros tamanduaís, teria cerca de 20 cm de comprimento de cabeça e corpo, uma cauda de comprimento similar e pesaria cerca de 300 gramas. O dorso deste tamanduaí é acinzentado, a parte traseira é amarela, o ventre é amarelo claro e a cauda é acinzentada. Possui uma faixa dorsal evidente, enquanto a faixa ventral é indistinta e irregular.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tamanduá",
                ani_Url = "https://www.xenarthrans.org/pt/tamanduas/tamanduai-de-thomas/"
            });

            Tamanduas.Add(new Animal
            {
                ani_Nome = "Tamanduá-Bandeira",
                ani_Localizacao = " Toda a América do Sul",
                ani_NomeCientifico = "Myrmecophaga tridactyla",
                ani_Descricao = "Com um comprimento de cabeça e corpo de 1 a 1,4 m, cauda de 60 a 90 cm e peso de 22 a 45 kg, essa é a maior espécie de tamanduá. Suas características mais notáveis são a cabeça alongada com uma boca pequena, circular e sem dentes; as orelhas pequenas e arredondadas, e a cauda longa, coberta de pelos grossos e compridos. O corpo é coberto por pelos grossos cuja cor varia de cinza claro a escuro ou marrom; também pode ser esbranquiçado. Uma característica banda triangular delimitada por linhas brancas se estende do peito e da garganta até as suas costas, e as pernas dianteiras brancas às vezes apresentam uma faixa ou manchas pretas. As mãos têm quatro dígitos, com o segundo e o terceiro apresentando garras longas e poderosas.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tamanduá",
                ani_Url = "https://www.xenarthrans.org/pt/tamanduas/tamanduai-do-xingu/"
            });

            Tamanduas.Add(new Animal
            {
                ani_Nome = "Tamanduá do Norte",
                ani_Localizacao = "Sul do México a Noroeste do Perú",
                ani_NomeCientifico = "Tamandua mexicana",
                ani_Descricao = "Este tamanduá de tamanho médio tem comprimento de cabeça e corpo de ca. 56 cm, uma cauda de 40–67 cm e peso de 3–6 kg. É um pouco menor e tem orelhas proporcionalmente menores que T. tetradactyla. Os olhos e a boca desdentada são pequenos. Possui quatro garras nos membros anteriores, sendo a segunda e a terceira garras bem desenvolvidas. O pelo curto e grosso cobre todo o corpo, exceto a ponta da cauda preênsil, últimos três quartos, é desnuda. A coloração mais comum é amarelo-bronzeado, tendo um colete negro nas costas e laterais, há também indivíduos totalmente amarelados, sem o colete.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tamanduá",
                ani_Url = "https://www.xenarthrans.org/pt/tamanduas/tamandua-bandeira-myrmecophaga-tridactyla/"
            });

            Tamanduas.Add(new Animal
            {
                ani_Nome = "Tamanduá-mirim",
                ani_Localizacao = "Leste da Cordilheira dos Andes a Sul da America do Sul",
                ani_NomeCientifico = "Tamandua tetradactyla",
                ani_Descricao = "AtéEste tamanduá de porte médio apresenta 47–77 cm de comprimento, cabeça e corpo, e possui uma cauda preênsil de 40–67 cm. Seu peso varia entre 3,5 e 8,4 kg. O focinho não é tão longo quanto o do tamanduá-bandeira, mas semelhante ao seu parente de maior porte possui uma boca pequena e desprovida de dentes, uma língua comprida (com até 40 cm), olhos pequenos e orelhas arredondadas. Os tamanduás-mirins podem ser dourados, castanhos ou pretos e podem ainda apresentar um padrão de pelagem preta em forma de colete, parcial ou completo. Os membros anteriores possuem três dígitos com garras, sendo que o terceiro apresenta a garra mais proeminente a qual é usada para abrir ninhos de formigas e de cupins, bem como para defesa. A parte ventral das patas do tamanduá-mirim é composta por tecido fibroso que as protege das pontas das garras enquanto eles caminham.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tamanduá",
                ani_Url = "https://www.xenarthrans.org/pt/tamanduas/tamandua-mirim/"
            });
        }
    }
}
