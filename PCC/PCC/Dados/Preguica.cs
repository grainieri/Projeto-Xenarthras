using PCC.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCC.Dados
{
    class Preguica
    {
        public static IList<Animal> Preguicas { get; private set; }

        static Preguica()
        {
            Preguicas = new List<Animal>();

            Preguicas.Add(new Animal
            {
                ani_Nome = "Preguiça-Anã",
                ani_Localizacao = "Ilha Escudo de Veraguas",
                ani_NomeCientifico = "Bradypus pygmaeus",
                ani_Descricao = "Esta é a menor das preguiças, medindo cerca de 50 cm e pesando entre 2,5 e 3,5 kg. Tem pelos longos e grossos de coloração cinza, cobertos de algas, fazendo com que o pelo pareça ser verde. As preguiças-anã têm um rosto marrom claro com uma faixa escura ao redor dos olhos. Os machos têm um espéculo dorsal de pelos mais curtos, de coloração creme a alaranjado. Como todas as preguiças do gênero Bradypus, esta espécie possui três unhas grandes em cada mão.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie="Preguiça",
                ani_Url= "https://www.xenarthrans.org/pt/preguicas/preguica-ana-bradypus-pygmaeus/"
            });

            Preguicas.Add(new Animal
            {
                ani_Nome = "Preguiça-De-Coleira ou Preguiça-Do-Norte",
                ani_Localizacao = "Mata Atlântica do leste do Brasil",
                ani_NomeCientifico = "Bradypus torquatus",
                ani_Descricao = "AtEsta preguiça tem comprimento de cabeça e corpo de 59–75 cm e uma cauda curta de 4 a 5 cm. O peso corporal varia de 4,6 a 10,1 kg. A preguiça-de-coleira macho é menor que a fêmea. A pelagem é marrom, os pelos são longos, grossos e frequentemente são colonizados por algas. Macho e fêmea têm uma crina preta ao redor da região dorsal do pescoço, sendo mais larga e escura nos machos.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Preguiça",
                ani_Url = "https://www.xenarthrans.org/pt/preguicas/preguica-de-coleira/"
            });

            Preguicas.Add(new Animal
            {
                ani_Nome = "Preguiça-De-Bentinho",
                ani_Localizacao = "Escudo das Guianas",
                ani_NomeCientifico = "Bradypus tridactylus",
                ani_Descricao = "A preguiça-de-bentinho mede 45–75 cm de comprimento, entre a cabeça e o corpo, e possui uma pequena cauda vestigial de 2–11 cm. Seu peso varia entre 3,4–6,5 kg. Os adultos possuem pelos longos, grossos, cinza escuros com manchas escuras nos ombros, costas e quadril. A testa e a garganta são amareladas. Os pelos podem parecer esverdeados devido às algas que aí crescem. Os machos são menores que as fêmeas e podem ser distinguidos pela mancha dorsal (chamada de espéculo) de cor amarelo-alaranjada com uma faixa central preta.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Preguiça",
                ani_Url = "https://www.xenarthrans.org/pt/preguicas/preguica-de-bentinho-b-tridactylus/"
            });

            Preguicas.Add(new Animal
            {
                ani_Nome = "Preguiça-De-Bentinho ou Preguiça-De-Óculos",
                ani_Localizacao = "Norte de Honduras",
                ani_NomeCientifico = "Bradypus variegatus",
                ani_Descricao = "Esta preguiça tem comprimento de cabeça e corpo de 52 a 54 cm, uma cauda vestigial de uns 5 cm e pesa cerca de 3,7 a 6 kg. Os membros anteriores são longos (37– 45 cm) e os posteriores são relativamente curtos (32–37 cm). Seu corpo está coberto por uma pelagem longa, grossa e grisalha, muitas vezes parece esverdeada devido as algas que crescem em seu pêlo. Sua face possui uma franja escura sobre uma cor mais clara e mais marrom, dando a aparência de uma máscara. Os machos têm uma mancha dorsal de pêlos mais curtos de cor creme a alaranjada, com uma franja escura que se extende verticalmente pelo centro de suas costas.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Preguiça",
                ani_Url = "https://www.xenarthrans.org/pt/preguicas/preguica-de-bentinho-b-variegatus/"
            });

            Preguicas.Add(new Animal
            {
                ani_Nome = "Preguiça De-Dois-Dedos",
                ani_Localizacao = "Venezuela, Guiana Francesa e Suriname",
                ani_NomeCientifico = "Choloepus didactylus",
                ani_Descricao = "A preguiça-de-dois-dedos tem comprimento de cabeça e corpo de 54–88 cm, uma cauda curta de 1–3,3 cm e peso entre 4 e 11 kg. É a maior espécie de preguiça existente na atualidade. Os membros anteriores e posteriores são tão longos que quase se igualam ao comprimento do animal, possui grandes garras curvas nos membros anteriores. Embora sua pelagem varie de marrom a marrom claro, indivíduos silvestres podem parecer verde pálido devido às algas que se desenvolvem nos pelos. Possui a mesma coloração na região da garganta e do peito, diferindo de Choloepus hoffmanni que tem a pelagem da garganta mais clara que a do peito. A face é marrom claro, sem pelos e textura coriácea. ",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Preguiça",
                ani_Url = "https://www.xenarthrans.org/pt/preguicas/preguica-de-dois-dedos/"
            });

            Preguicas.Add(new Animal
            {
                ani_Nome = "Preguiça-Real",
                ani_Localizacao = "Sul de Honduras até a América do Sul",
                ani_NomeCientifico = "Choloepus hoffmanni",
                ani_Descricao = "AtéEsta preguiça mede entre 50–70 cm de comprimento, entre a cabeça e o corpo, possui uma cauda vestigial de 1,4–3 cm e pesa entre 2,7–10 kg. Os braços e pernas são longos e possuem quase o mesmo comprimento. As duas garras das mãos e as três garras dos pés medem cerca de 5–6,5 cm, enquanto que os pelos do corpo variam de amarelado, loiro, bege ou bronzeado ao marrom claro em adultos. Contudo, a coloração do corpo pode parecer esverdeada por conta das algas que crescem em seus pelos. O rosto é geralmente mais claro que o restante do corpo e os pelos são mais curtos e finos na face e garganta, do que os do pescoço e ombro.",
                ani_UrlImagem = "https://www.xenarthrans.org/wp-content/uploads/2019/10/Dise%C3%B1o-sin-t%C3%ADtulo-41.png",
                ani_Especie = "Preguiça",
                ani_Url = "https://www.xenarthrans.org/pt/preguicas/preguica-real/"
            });
        }
    }
}
