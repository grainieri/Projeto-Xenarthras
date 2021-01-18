using PCC.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCC.Dados
{
    class Tatu
    {
        public static IList<Animal> Tatus { get; private set; }

        static Tatu()
        {
            Tatus = new List<Animal>();

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-de-Rabo-Mole da Centroamérica",
                ani_Localizacao = "Sul do México, a América do Sul",
                ani_NomeCientifico = "Cabassous centralis",
                ani_Descricao = "Esta espécie de tatu tem comprimento de cabeça e corpo de 30 a 38 cm, uma cauda de 13 a 18 cm e pesa entre 2 a 3,5 kg. Sua carapaça é cinza escura contornada por uma faixa rosada na parte inferior. Possui de 11 a 13 bandas móveis. Como o nome comum desta espécie indica, sua cauda é nua, i.e., possui placas espaçadas, sem a completa armadura presente em outros tatus. Suas orelhas, com 3 a 3,7 cm de comprimento, são moderadamente grandes e em forma de funil, com sua parte posterior desnuda. Os olhos são extremamente pequenos.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-de-Rabo-Mole do Chaco",
                ani_Localizacao = "Oeste do Paraguai a Centro Norte Argentino",
                ani_NomeCientifico = "Cabassous chacoensis",
                ani_Descricao = "Com medidas que variam de 30–35 cm, entre cabeça e corpo, 9–10 cm de cauda e peso de 1–2,4 kg, o tatu de rabo mole do Chaco é a menor espécie do gênero Cabassous. Este tatu também pode ser distinguido das outras espécies de Cabassous por suas orelhas minúsculas. Diferente dos outros tatus, as espécies do gênero Cabassous não possuem carapaça em suas caudas, podendo haver somente algumas poucas placas ósseas na camada dérmica da pele (osteodermas).",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            }); 

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-de-Rabo-Mole-Grande",
                ani_Localizacao = "Sul do Brasil",
                ani_NomeCientifico = "Cabassous tatouay",
                ani_Descricao = "Com comprimento de cabeça-corpo de 36 a 49 cm e cauda de 15 a 20 cm, esta é a maior espécie dos tatus-de-rabo-mole. A carapaça varia de marrom avermelhada a cinza escuro e tem 12–13 bandas móveis. Como o nome comum desta espécie indica, a cauda é nua, i. e., possui poucos escudos que são pequenos e bem espaçados, sem o completo revestimento da cauda como presente em outros tatus. Suas orelhas têm cerca de 4 cm de comprimento, são afuniladas e bem separadas uma da outra.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-de-Rabo-Mole-Pequeno",
                ani_Localizacao = "Leste dos Andes",
                ani_NomeCientifico = "Cabassous unicinctus",
                ani_Descricao = "Há duas subespécies de C. unicinctus que merecem sua descrição por serem bastante distintas: Cabassous u. unicinctus tem comprimento de cabeça e corpo de 35 a 44 cm, uma cauda de 16 a 20 cm de comprimento e pesa entre 2,5 a 3,6 kg. Sua carapaça é cinza escura com uma borda clara e rosada ao redor da parte inferior da mesma. Cabassous u. squamicaudis tem comprimento de cabeça e corpo de 29 a 34 cm, uma cauda de 9 a 14 cm de comprimento e pesa entre 1,6 a 1,8 kg. Sua carapaça é cinza escura uniforme. Ambas espécies têm de 10 a 13 bandas em sua carapaça, longas unhas e uma cauda cinza e nua, isto é, falta a cobertura completa presente em outros tatus, sendo que pode haver alguns escudos dérmicos isolados em C. u. squamicaudis.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Pichiciego Maior",
                ani_Localizacao = "Região do Gran Chaco",
                ani_NomeCientifico = "Calyptophractus retusus",
                ani_Descricao = "Este pequeno tatu tem um comprimento de cabeça-corpo de 12 a 17 cm, uma cauda de 3 a 4 cm de comprimento e pesa entre 90 e 130 gramas. É similar a uma toupeira, com corpo fusiforme, garras muito grandes para escavar, e uma placa vertical arredondada cobre sua parte traseira. Diferente de Chlamyphorus truncatus, nesta espécie a carapaça rosada está completamente unida à pele do dorso e da cabeça. Outras diferenças em relação a C. truncatus são a ponta arredondada da cauda e as orelhas visíveis.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-Chorão",
                ani_Localizacao = "Bolívia",
                ani_NomeCientifico = "Chaetophractus vellerosus",
                ani_Descricao = "O tatu-chorão é uma espécie relativamente pequena e a menor dos Euphractinae. Ele pesa entre 0,6 e 1,2 kg e tem um comprimento de cabeça-corpo de 20 a 30 cm. Sua carapaça possui 6 a 8 faixas móveis e 1 ou 2 pequenas aberturas para as glândulas pélvicas, na linha dorsal média do escudo pélvico. A carapaça pode ser marrom ou castanho claro e está relativamente densamente coberta de pelos. Um aspecto notável do tatu-chorão são suas orelhas proporcionalmente longas, que podem medir até 3,2 cm de comprimento. Até 2015, Chaetophractus nationi era classificada como espécie, embora sua validade taxonômica já tivesse sido questionada na década de 1980. Estudos morfológicos e moleculares recentes confirmaram que não existem diferenças suficientes entre C. nationi e C. vellerosus para classificá-los como espécies separadas. Como conseqüência, ambas duas foram sinonimizadas, o que significa que C. nationi e C. vellerosus agora são consideradas a mesma espécie, denominada Chaetophractus vellerosus.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-Peludo",
                ani_Localizacao = "Sudeste da Bolívia",
                ani_NomeCientifico = "Chaetophractus villosus",
                ani_Descricao = "Chaetophractus villosus tem um comprimento de cabeça-corpo de 26 a 40 cm, uma cauda de 12 a 15 cm, orelhas proporcionalmente curtas de cerca de 3 cm de comprimento, e pesa de 2 a 5 kg. A carapaça é achatada e escura, com pelos escuros e longos espalhados, e 6 ou 7 bandas móveis transversais. Na linha média do escudo pélvico há 2 ou 3 pequenas aberturas, correspondentes às glândulas pélvicas.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Pichi Cego",
                ani_Localizacao = "Argentina",
                ani_NomeCientifico = "Chlamyphorus truncatus",
                ani_Descricao = "Este é o menor de todos os tatus. Mede cerca de 11 a 15 cm da cabeça até a base da cauda e pesa cerca de 100 gramas. Sua carapaça é rosada e unida ao corpo apenas por uma fina membrana ao longo da linha dorsal, mas livre do corpo pelas laterais. Pelos brancos e sedosos cobrem as partes ventral e lateral do corpo, estendendo-se sob a carapaça. Outra característica incomum do pichi cego é a sua placa posterior arredondada e vertical. As garras dianteiras (para escavação) são ampliadas, por isso caminha nas pontas das garras. A ponta da cauda é em forma de diamante e as orelhas não são visíveis.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-Quinze-Quilos",
                ani_Localizacao = "Rio Amazonas e Madeira",
                ani_NomeCientifico = "Dasypus beniensis",
                ani_Descricao = "Até pouco tempo, Dasypus kappleri era considerada uma única espécie. Recentes análises morfológicas, morfométricas e moleculares sugerem que “D. kappleri” na verdade representa um complexo de espécies contendo D. kappleri, D. pastasae e D. beniensis. Somente superado em tamanho pelo tatu-canastra (Priodontes maximus), D. beniensis tem comprimento cabeça-corpo de 51–58 cm e comprimento caudal de 33–48 cm, enquanto sua carapaça tem 7–8 bandas móveis. Seu peso provavelmente seja de cerca de 8,5–10,5 kg, mas foi descrita como a maior das três espécies do complexo “D. kappleri”. Além de seu tamanho, pode-se distinguir de outros tatus do gênero Dasypus pelas escamas grandes e projetadas presentes nos joelhos, uma ampla base da cauda, e uma cor de pele mais clara na parte da cabeça que não está coberta pelo escudo cefálico. Similar externamente a D. pastasae, a espécie possui escamas ásperas no escudo pélvico e escamas achatadas nos anéis caudais proximais. Além disso, apresenta características cranianas que podem ser observadas em espécies de coleção, mas não em exemplares vivos.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatuíra",
                ani_Localizacao = "Argentina, Uruguai, Paraguai e Sul do Brasil",
                ani_NomeCientifico = "Dasypus hybridus",
                ani_Descricao = "O tatuíra tem cabeça delgada com comprimento de 26–31 cm, orelhas de 2–3 cm e cauda de 15–19 cm. Sua carapaça geralmente tem 6-7 bandas móveis, às vezes 8 bandas. Pesa em torno de 2 kg.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-Quinze-Quilos",
                ani_Localizacao = "Escudo da Guiana",
                ani_NomeCientifico = "Dasypus kappleri",
                ani_Descricao = "Até pouco tempo, Dasypus kappleri era considerada uma única espécie. Recentes análises morfológicas, morfométricas e moleculares sugerem que “D. kappleri” na verdade representa um complexo de espécies contendo D. kappleri, D. pastasae e D. beniensis. Somente superado em tamanho pelo tatu canastra (Priodontes maximus), o tatu-quinze-quilos tem comprimento cabeça-corpo de 51–58 cm e um comprimento caudal de 33–48 cm, enquanto sua carapaça tem 7–8 bandas móveis. Seu peso provavelmente seja de cerca de 8,5–10,5 kg. Além de seu tamanho, pode-se distinguir de outros tatus do gênero Dasypus por escamas grandes e projetadas presentes nos joelhos, uma ampla base da cauda, e uma cor de pele mais clara na parte da cabeça que não está coberta pelo escudo cefálico. Aparentemente, D. kappleri pode ser distinguido de D. pastasae e D. beniensis por seu padrão único de escamas lisas, achatadas e uniformes no escudo pélvico, com as escamas centrais e periféricas no mesmo nível, e por escamas com quilhas nos anéis proximais da cauda.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-de-Mazza",
                ani_Localizacao = "Argentina",
                ani_NomeCientifico = "Dasypus mazzai",
                ani_Descricao = "O tatu-de-Mazza tem comprimento de cabeça e corpo de uns 31 cm, uma cauda relativamente longa de 18 a 23 cm e orelhas proporcionalmente longas, de 3,6 a 3,8 cm. Sua carapaça geralmente tem 7 a 8 bandas e seu peso varia de 2 a 2,5 kg.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-Galinha",
                ani_Localizacao = "Sul dos Estados Unidos a Uruguai",
                ani_NomeCientifico = "Dasypus novemcinctus",
                ani_Descricao = "O tatu-galinha tem comprimento de cabeça e corpo de 36 a 57 cm e cauda de 26 a 45 cm, as orelhas são proporcionalmente grandes com 2,5 a 5,7 cm de comprimento e pesa entre 3 e 6 kg. Apesar do seu nome comum, ele pode ter entre 7 e 11 bandas móveis, sendo mais comum ter 9 bandas. A carapaça geralmente contém áreas claras ou amareladas nas laterais do corpo.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-Quinze-Quilos",
                ani_Localizacao = "Andes Orientais a Oeste da Amazônia",
                ani_NomeCientifico = "Dasypus pastasae",
                ani_Descricao = "Até pouco tempo, Dasypus kappleri era considerada uma única espécie. Recentes análises morfológicas, morfométricas e moleculares sugerem que “D. kappleri” na verdade representa um complexo de espécies contendo D. kappleri, D. pastasae e D. beniensis. Somente superado em tamanho pelo tatu canastra (Priodontes maximus), o tatu-quinze-quilos tem comprimento cabeça-corpo de 51–58 cm e um comprimento caudal de 33–48 cm, enquanto sua carapaça tem 7–8 bandas móveis. Seu peso provavelmente seja de cerca de 8,5–10,5 kg, mas parece ser a menor das espécies do complexo “D. kappleri”. Além de seu tamanho, pode-se distinguir de outros tatus do gênero Dasypus por escamas grandes e projetadas presentes nos joelhos, uma ampla base da cauda, e uma cor de pele mais clara na parte da cabeça que não está coberta pelo escudo cefálico. Em relação a D. kappleri e D. beniensis, as escamas no escudo pélvico desta espécie não são uniformes quanto ao tamanho e textura, que é áspera, com as escamas centrais maiores e em nível mais alto que as periféricas, que são menores. Também, as escamas posteriores dos anéis proximais da cauda são achatadas. ",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-Peludo",
                ani_Localizacao = "Peru",
                ani_NomeCientifico = "Dasypus pilosus",
                ani_Descricao = "O tatu-peludo tem comprimento de cabeça e corpo de 32–44 cm, uma cauda de 23–31 cm, as orelhas têm cerca de 5 cm, pesa 1–1,5 kg e possui de 9 a 11 bandas móveis. É muito diferente dos outros tatus do gênero Dasypus devido à grossa pelagem avermelhada a cinza avermelhada que cobre sua carapaça, laterais da cabeça e parte superior de seus membros.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-das-Savanas",
                ani_Localizacao = "Planicies da Venezuela e Colômbia",
                ani_NomeCientifico = "Dasypus sabanicola",
                ani_Descricao = "Este tatu é o segundo menor entre os Dasypus, seu comprimento de cabeça-corpo é de 25–31 cm, com 8 bandas móveis, cauda relativamente longa (17–21 cm) e peso corporal de 1–2 kg. É parecido com o tatu-galinha (D. novemcinctus) jovem. Entretanto, o tatu-das-savanas tem o focinho mais curto que o tatu-galinha e a carapaça tem coloração mais uniforme.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-í",
                ani_Localizacao = "Bacia Amazônica a Gran Chaco",
                ani_NomeCientifico = "Dasypus septemcinctus",
                ani_Descricao = "Este tatu é o menor do gênero Dasypus, tem comprimento de cabeça e corpo de 24 a 31 cm, uma cauda de 12 a 17 cm, orelhas proporcionalmente grandes de 2,6 a 3,8 cm e pesa cerca de 1 a 1,5 kg. A carapaça varia de acinzentada a cinza-castanho e geralmente tem 7 bandas móveis. Esta espécie é muito similar em aparência a outros tatus como D. sabanicola, D. hybridus e D. mazzai e também com o jovem de D. novemcinctus; por isso, as identificações errôneas são muito frequentes.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-Peba",
                ani_Localizacao = "América do Sul a Centro Norte Argentino",
                ani_NomeCientifico = "Euphractus sexcinctus",
                ani_Descricao = "Este tatu relativamente grande tem um comprimento cabeça-corpo de 40 a 50 cm, uma cauda de 20 a 25 cm, orelhas proporcionalmente longas de 3,5 a 4,1 cm, e pesa entre 3 e 7 kg. Sua carapaça é de coloração amarelo-pálido, marrom ou marrom-avermelhado, coberta por pelos claros espalhados, e tipicamente tem seis bandas móveis. Há de 2 a 4 aberturas de glândulas pélvicas na linha média dorsal do escudo pélvico.Este tatu relativamente grande tem um comprimento cabeça-corpo de 40 a 50 cm, uma cauda de 20 a 25 cm, orelhas proporcionalmente longas de 3,5 a 4,1 cm, e pesa entre 3 e 7 kg. Sua carapaça é de coloração amarelo-pálido, marrom ou marrom-avermelhado, coberta por pelos claros espalhados, e tipicamente tem seis bandas móveis. Há de 2 a 4 aberturas de glândulas pélvicas na linha média dorsal do escudo pélvico.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-Canastra",
                ani_Localizacao = "Leste dos Andes",
                ani_NomeCientifico = "Priodontes maximus",
                ani_Descricao = "Esta é a maior de todas as espécies de tatus existentes. Mede entre 75 e 100 cm desde a sua cabeça até a base da cauda, a qual tem um cumprimento entre 40 a 50 cm. Seu peso varia entre 20 e 60 kg, mas em condições de cativeiro foram registrados animais de até 80 kg. A carapaça tem entre 11 e 13 faixas móveis, ela pode variar entre marrom-escura e preta e tem uma larga faixa de cor clara ao redor de sua margem inferior. As garras nos seus dedos das patas da frente são grossas e muito fortes.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-bola",
                ani_Localizacao = "Leste da Bolívia a Centro da Argentina",
                ani_NomeCientifico = "Tolypeutes matacus",
                ani_Descricao = "O tatu-bola tem comprimento de cabeça-corpo de 20 a 25 cm e pesa em torno de 1 a 2 kg. Sua carapaça é rígida, arredondada, geralmente amarelo-escuro a marrom, tem 2 a 4 bandas móveis. A cauda, assim como o escudo cefálico, tem forma triangular. Tem 3 a 4 dedos com garras nos membros anteriores, com a terceira garra maior.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Tatu-bola",
                ani_Localizacao = "Nordeste do Brasil",
                ani_NomeCientifico = "Tolypeutes tricinctus",
                ani_Descricao = "O Tatu bola mede cerca de 23–25 cm de comprimento (cabeça e corpo) e pesa em torno de 1–1,8 kg. Sua carapaça em forma de abóboda varia de bege claro a castanho, é rígida e possui de 2 a 4 cintas móveis. A cauda, assim como o escudo da cabeça, têm formato triangular. Quando o animal se enrola, as carapaças da cabeça e da cauda se encaixam com a carapaça do restante do corpo formando uma bola perfeita. Os membros anteriores possuem cinco dedos com garras, sendo o terceiro o maior de todos.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });

            Tatus.Add(new Animal
            {
                ani_Nome = "Piche",
                ani_Localizacao = "Estepes Patagônicas e dos Pampas",
                ani_NomeCientifico = "Zaedyus pichiy",
                ani_Descricao = "Este pequeno tatu tem um comprimento cabeça-corpo de 22–31 cm, cauda de 8–13 cm de comprimento, e orelhas proporcionalmente curtas, de aproximadamente 1,5 cm de comprimento. Pesa de 0,7–1,5 kg. A cor da carapaça varia de amarelo claro a quase preta, com uma faixa mais clara, de comprimento e largura variáveis, no dorso. Possui 6–8 bandas móveis, e pelos relativamente longos se projetam através das placas ósseas e das escamas. As placas na borda da carapaça são pontiagudas.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Tatu"
            });
        }
    }
}
