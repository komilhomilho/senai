using System;

namespace Exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==================================================
            // EXEMPLO TESTE 1 - DANO CAUSADO PELO PERSONAGEM
            // ==================================================
            Console.WriteLine("=== TESTE 1: DANO DO PERSONAGEM ===");

            int bonusDano = 15;

            int danoTotal = CalcularDano(bonusDano);

            Console.WriteLine($"Ataque base: 25");
            Console.WriteLine($"Bônus da arma: {bonusDano}");
            Console.WriteLine($"Dano total: {danoTotal}");

            Console.WriteLine();


            // ==================================================
            // EXEMPLO TESTE 2 - SISTEMA DE PONTUAÇÃO POR MISSÕES
            // ==================================================
            Console.WriteLine("=== TESTE 2: PONTUAÇÃO POR MISSÕES ===");

            int pontuacaoInicial = 50;
            int qtdMissoes = 3;

            Console.WriteLine($"Pontuação inicial: {pontuacaoInicial}");
            Console.WriteLine($"Quantidade de missões: {qtdMissoes}");
            Console.WriteLine();

            int pontuacaoFinal = AtualizarPontuacao(
                pontuacaoInicial,
                qtdMissoes
            );

            Console.WriteLine();
            Console.WriteLine($"Pontuação final: {pontuacaoFinal}");

            Console.WriteLine();


            // ==================================================
            // EXEMPLO TESTE 3 - DIFICULDADE DO INIMIGO
            // ==================================================
            Console.WriteLine("=== TESTE 3: DIFICULDADE DO INIMIGO ===");

            int nivel1 = 3;
            int nivel2 = 8;
            int nivel3 = 15;
            int nivel4 = 25;
            int nivel5 = 0;

            Console.WriteLine(
                $"Nível {nivel1}: {ClassificarInimigo(nivel1)}"
            );

            Console.WriteLine(
                $"Nível {nivel2}: {ClassificarInimigo(nivel2)}"
            );

            Console.WriteLine(
                $"Nível {nivel3}: {ClassificarInimigo(nivel3)}"
            );

            Console.WriteLine(
                $"Nível {nivel4}: {ClassificarInimigo(nivel4)}"
            );

            Console.WriteLine(
                $"Nível {nivel5}: {ClassificarInimigo(nivel5)}"
            );

            Console.WriteLine();


            // ==================================================
            // SEUS TESTES
            // ==================================================
            // Execute seus próprios testes aqui.
            // Experimente alterar os valores de entrada
            // e verificar os resultados dos métodos.
            Console.WriteLine("=== MEUS TESTES ===");

            Console.WriteLine("--- Testando Ex 1: Poção de Vida ---");
            Console.WriteLine($"Curando 20 de vida: {PocaoDeVida(20)}");
            Console.WriteLine($"Tentando curar valor negativo (-10): {PocaoDeVida(-10)} (Deve continuar 50)");
            Console.WriteLine();

            Console.WriteLine("--- Testando Ex 4: Compra de Itens ---");
            Console.WriteLine($"Comprando item de 75 moedas: {ComprarItem(75)} restantes");
            Console.WriteLine($"Comprando item mais caro que o saldo (300 moedas): {ComprarItem(300)} restantes");
            Console.WriteLine();

            Console.WriteLine("--- Testando Ex 7: O Chefe Final ---");
            Console.WriteLine("Batalha com espada forte (causando 120 de dano por ataque):");
            CalcularAtaquesParaDerrotarChefe(120);
            Console.WriteLine();

            Console.WriteLine("--- Testando Ex 8: Poções de Cura (Limites) ---");
            Console.WriteLine($"Vida 80 + Poção Média (Tipo 2): {UsarPocao(80, 2)} (Limite é 100)");
            Console.WriteLine($"Vida 50 + Poção Suprema (Tipo 3): {UsarPocao(50, 3)} (Não pode passar de 100)");
            Console.WriteLine();

            Console.WriteLine("--- Testando Ex 9: Escudo do Personagem ---");
            Console.WriteLine($"Recebendo 60 de dano COM escudo: {CalcularDanoRecebido(60, true)}");
            Console.WriteLine($"Recebendo 60 de dano SEM escudo: {CalcularDanoRecebido(60, false)}");
            Console.WriteLine();

            Console.WriteLine("--- Testando Ex 10: Classificação da Recompensa ---");
            Console.WriteLine($"Pontos: 85 -> {ClassificarRecompensa(85)}");
            Console.WriteLine($"Pontos: 600 -> {ClassificarRecompensa(600)}");
            Console.WriteLine($"Pontos: 1500 -> {ClassificarRecompensa(1500)}");
            Console.WriteLine($"Pontos: -50 -> {ClassificarRecompensa(-50)}");
            Console.WriteLine();



            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadKey();
            
        }

        // ==================================================
        // 1. POÇÃO DE VIDA
        // Conceitos: parâmetros, retorno e soma.
        // ==================================================
        static int PocaoDeVida(int vidaRecuperada)
        {
            /*
    - Enunciado:
    - O personagem possui 50 pontos de vida e encontrou
    - uma poção que recupera uma quantidade de vida.
             *
    - Crie um método que receba a quantidade de vida
    - recuperada e retorne a vida atualizada.
             *
    - Exemplos:
    - Entrada: vida atual = 50, vidaRecuperada = 10
    - Saída esperada: 60
             */
            int vidaAtual = 50;
            if (vidaRecuperada <= 0)
            {
                return vidaAtual;
            }
            return vidaAtual + vidaRecuperada;
        }

        // ==================================================
        // 2. RECOMPENSA POR DERROTAR INIMIGO
        // Conceitos: parâmetros, retorno e soma.
        // ==================================================
        static int RecompensaInimigo(int moedasRecebidas)
        {
            /*
    - Enunciado:
    - O personagem possui 120 moedas e derrotou um
    - inimigo que concedeu uma recompensa em moedas.
             *
    - Crie um método que receba a quantidade de moedas
    - recebidas e retorne o total atualizado.
             *
    - Exemplos:
    - Entrada: moedas atuais = 120, moedasRecebidas = 35
    - Saída esperada: 155
             */
            int qtdMoedas = 120;
            if (moedasRecebidas <= 0)
            {
                return qtdMoedas;
            }
            return qtdMoedas + moedasRecebidas;
        }

        // ==================================================
        // 3. DANO RECEBIDO PELO INIMIGO
        // Conceitos: parâmetros, retorno e subtração.
        // ==================================================
        static int CalcularVidaRestante(int danoCausado)
        {
            /*
    - Enunciado:
    - Um inimigo possui 100 pontos de vida e recebe
    - um ataque que causa determinada quantidade de dano.
             *
    - Crie um método que receba o dano causado e retorne
    - a quantidade de vida restante do inimigo.
             *
    - Exemplos:
    - Entrada: vida do inimigo = 100, danoCausado = 30
    - Saída esperada: 70
             */
            int vidaInimigo = 100;
            if (danoCausado <= 0)
            {
                return vidaInimigo;
            }
            
            int restante = vidaInimigo - danoCausado;
            if (restante < 0)
            {
                return 0;
            }
            return restante;
        }
        
        // ==================================================
        // 4. COMPRA DE ITENS
        // Conceitos: parâmetros, retorno e subtração.
        // ==================================================
        static int ComprarItem(int precoItem)
        {
            /*
    - Enunciado:
    - O personagem possui 200 moedas e deseja comprar
    - um item na loja do jogo.
             *
    - Crie um método que receba o preço do item
    - e retorne quantas moedas restarão após a compra.
             *
    - Exemplos:
    - Entrada: moedas atuais = 200, precoItem = 75
    - Saída esperada: 125
             */
            int moedasAtuais = 200;
            if (precoItem <= 0)
            {
                return moedasAtuais;
            }
            if (precoItem > moedasAtuais)
            {
                return moedasAtuais; 
            }
            
            return moedasAtuais - precoItem;
        }

        // ==================================================
        // 5. COLETANDO MOEDAS PELO MAPA
        // Conceitos: loops, acumulador, parâmetros e saída de mensagens.
        // ==================================================
        static int CalcularPontosMoedas(int moedasColetadas, int pontuacaoAtual)
        {
            /*
    - Enunciado:
    - Durante uma fase do jogo, o personagem encontra
    - várias moedas espalhadas pelo cenário.
             *
    - Cada moeda coletada adiciona 10 pontos à
    - pontuação atual do personagem.
             *
    - Crie um método que receba como parâmetros a
    - quantidade de moedas coletadas e a pontuação
    - atual do personagem.
             *
    - Utilize uma estrutura de repetição para simular
    - a coleta de cada moeda. A cada iteração, adicione
    - 10 pontos à pontuação e exiba uma mensagem
    - informando a pontuação atualizada.
             *
    - Ao final, retorne a pontuação total do jogador.
             *
    - Exemplos:
    - Entrada: moedasColetadas = 8
    - Entrada: pontuacaoAtual = 10
    - Valor por moeda: 10 pontos
             *
    - Saída esperada:
    - Moeda coletada! Pontuação atual: 20
    - Moeda coletada! Pontuação atual: 30
    - Moeda coletada! Pontuação atual: 40
    - Moeda coletada! Pontuação atual: 50
    - Moeda coletada! Pontuação atual: 60
    - Moeda coletada! Pontuação atual: 70
    - Moeda coletada! Pontuação atual: 80
    - Moeda coletada! Pontuação atual: 90
             *
    - Retorno esperado: 90
             */
            if (moedasColetadas <= 0)
            {
                return pontuacaoAtual;
            }

            for (int i = 0; i < moedasColetadas; i++)
            {
                pontuacaoAtual += 10;
                Console.WriteLine($"Moeda coletada! Pontuação atual: {pontuacaoAtual}");
            }

            return pontuacaoAtual;
        }

        // ==================================================
        // 6. ATAQUES CONSECUTIVOS
        // Conceitos: loops, acumuladores e soma por repetição.
        // ==================================================
        static int CalcularDanoTotal(int quantidadeAtaques)
        {
            /*
    - Enunciado:
    - O personagem possui um ataque que causa
    - 15 pontos de dano.
             *
    - Durante uma habilidade especial, ele pode
    - realizar vários ataques consecutivos.
             *
    - Crie um método que receba a quantidade de ataques
    - e utilize uma estrutura de repetição para calcular
    - o dano total causado.
             *
    - Exemplos:
    - Entrada: quantidadeAtaques = 4
    - Dano por ataque: 15
    - Saída esperada: 60
             */
            if (quantidadeAtaques <= 0)
            {
                return 0;
            }

            int danoTotal = 0;
            for (int i = 0; i < quantidadeAtaques; i++)
            {
                danoTotal += 15;
            }

            return danoTotal;
        }

        // ==================================================
        // 7. O CHEFE FINAL
        // Conceitos: loops, contador, subtração e condição de parada.
        // ==================================================
        static int CalcularAtaquesParaDerrotarChefe(int danoPorAtaque)
        {
            /*
    - Enunciado:
    - O personagem chegou à batalha final contra o chefe!
             *
    - O chefe possui 500 pontos de vida e o personagem
    - causa 15 pontos de dano a cada ataque.
             *
    - Crie um método que receba como parâmetro o dano
    - causado por cada ataque.
             *
    - Utilize uma estrutura de repetição while para
    - simular os ataques do personagem até que a vida
    - do chefe chegue a zero ou menos.
             *
    - A cada ataque realizado, subtraia o dano causado
    - da vida do chefe e exiba uma mensagem informando
    - quantos pontos de vida ainda restam.
             *
    - O método também deverá contabilizar a quantidade
    - de ataques realizados e, ao final, retornar esse
    - total.
             *
    - Exemplos:
    - Entrada: vida inicial do chefe = 500
    - Entrada: danoPorAtaque = 15
             *
    - Saída esperada:
    - Ataque 1! Vida do chefe: 485
    - Ataque 2! Vida do chefe: 470
    - Ataque 3! Vida do chefe: 455
    - Ataque 4! Vida do chefe: 440
    - ...
    - Ataque 32! Vida do chefe: 20
    - Ataque 33! Vida do chefe: 5
    - Ataque 34! Vida do chefe: -10
             *
    - Chefe derrotado!
    - Total de ataques: 34
             *
    - Retorno esperado: 34
             */
            if (danoPorAtaque <= 0)
            {
                return 0;
            }

            int vidaChefe = 500;
            int ataquesContabilizados = 0;

            while (vidaChefe > 0)
            {
                vidaChefe -= danoPorAtaque;
                ataquesContabilizados++;
                Console.WriteLine($"Ataque {ataquesContabilizados}! Vida do chefe: {vidaChefe}");
            }

            Console.WriteLine("Chefe derrotado!");
            Console.WriteLine($"Total de ataques: {ataquesContabilizados}");

            return ataquesContabilizados;
        }
        
        // ==================================================
        // 8. POÇÕES DE CURA
        // Conceitos: if, comparação, soma e limite máximo.
        // ==================================================
        static int UsarPocao(int vidaAtual, int tipoPocao)
        {
            /*
    - Enunciado:
    - Durante sua aventura, o personagem encontrou
    - diferentes tipos de poções de cura.
             *
    - Cada poção recupera uma quantidade específica
    - de pontos de vida:
             *
    - Poção 1 - Poção Menor: recupera 10 pontos de vida.
    - Poção 2 - Poção Média: recupera 30 pontos de vida.
    - Poção 3 - Poção Suprema: recupera 60 pontos de vida.
             *
    - O personagem possui um limite máximo de
    - 100 pontos de vida.
             *
    - Crie um método que receba como parâmetros a
    - vida atual do personagem e o tipo de poção utilizada.
             *
    - Utilize estruturas condicionais para identificar
    - a poção escolhida e recuperar a quantidade
    - correspondente de pontos de vida.
             *
    - Caso a recuperação ultrapasse o limite máximo,
    - a vida do personagem deverá permanecer em 100.
             *
    - Ao final, retorne a quantidade atualizada
    - de pontos de vida.
             *
    - Exemplos:
             *
    - Entrada: vidaAtual = 80, tipoPocao = 1
    - Poção utilizada: Poção Menor (+10)
    - Saída esperada: 90
             *
    - Entrada: vidaAtual = 80, tipoPocao = 2
    - Poção utilizada: Poção Média (+30)
    - Saída esperada: 100
             *
    - Entrada: vidaAtual = 50, tipoPocao = 3
    - Poção utilizada: Poção Suprema (+60)
    - Saída esperada: 100
             *
    - Entrada: vidaAtual = 100, tipoPocao = 1
    - Poção utilizada: Poção Menor (+10)
    - Saída esperada: 100
             */
            if (vidaAtual < 0)
            {
                vidaAtual = 0;
            }
            if (vidaAtual >= 100)
            {
                return 100;
            }

            int cura = 0;

            if (tipoPocao == 1)
            {
                cura = 10;
            }
            else if (tipoPocao == 2)
            {
                cura = 30;
            }
            else if (tipoPocao == 3)
            {
                cura = 60;
            }
            else
            {
                return vidaAtual;
            }

            vidaAtual += cura;

            if (vidaAtual > 100)
            {
                return 100;
            }

            return vidaAtual;
        }

        // ==================================================
        // 9. ESCUDO DO PERSONAGEM
        // Conceitos: if/else, parâmetros e divisão.
        // ==================================================
        static int CalcularDanoRecebido(int danoInimigo, bool escudoAtivado)
        {
            /*
    - Enunciado:
    - Durante uma batalha, o personagem pode receber
    - um ataque de um inimigo.
             *
    - Se o escudo estiver ativado, o personagem receberá
    - apenas metade do dano.
             *
    - Caso contrário, receberá o dano completo.
             *
    - Crie um método que receba o dano do inimigo e
    - uma informação indicando se o escudo está ativado.
             *
    - Retorne o dano que realmente será aplicado
    - ao personagem.
             *
    - Exemplos:
    - Entrada: danoInimigo = 40, escudoAtivado = true
    - Saída esperada: 20
             *
    - Entrada: danoInimigo = 40, escudoAtivado = false
    - Saída esperada: 40
             */
            if (danoInimigo <= 0)
            {
                return 0;
            }

            if (escudoAtivado)
            {
                return danoInimigo / 2;
            }
            
            return danoInimigo;
        }

        // ==================================================
        // 10. CLASSIFICAÇÃO DA RECOMPENSA
        // Conceitos: if, else if, else e operadores relacionais.
        // ==================================================
        static string ClassificarRecompensa(int pontosConquistados)
        {
            /*
    - Enunciado:
    - Após completar uma missão, o jogador recebe
    - uma classificação baseada nos pontos conquistados.
             *
    - Utilize as seguintes regras:
             *
    - Menos de 100 pontos: "Bronze"
    - De 100 até 499 pontos: "Prata"
    - De 500 até 999 pontos: "Ouro"
    - 1000 pontos ou mais: "Diamante"
             *
    - Crie um método que receba a quantidade de pontos
    - e retorne a classificação da recompensa.
             *
    - Exemplos:
    - Entrada: pontosConquistados = 80
    - Saída esperada: "Bronze"
             *
    - Entrada: pontosConquistados = 250
    - Saída esperada: "Prata"
             *
    - Entrada: pontosConquistados = 750
    - Saída esperada: "Ouro"
             *
    - Entrada: pontosConquistados = 1500
    - Saída esperada: "Diamante"
             */
            if (pontosConquistados < 0)
            {
                return "Pontuação inválida";
            }

            if (pontosConquistados < 100)
            {
                return "Bronze";
            }
            else if (pontosConquistados <= 499)
            {
                return "Prata";
            }
            else if (pontosConquistados <= 999)
            {
                return "Ouro";
            }
            else
            {
                return "Diamante";
            }
        }
        
        
        // ==================================================
        // EXEMPLO 1
        // DANO CAUSADO PELO PERSONAGEM
        // Conceitos: parâmetros, retorno e soma.
        // ==================================================
        static int CalcularDano(int bonusDano)
        {
            /*
    - Enunciado:
    - O personagem possui 25 pontos de ataque base
    - e utiliza uma arma que adiciona um bônus de dano.
             *
    - Crie um método que receba o bônus de dano da arma
    - e retorne o dano total causado pelo personagem.
             *
    - Exemplos:
    - Entrada: ataque base = 25, bonusDano = 15
    - Saída esperada: 40
             */
            int ataqueBase = 25;
            if (bonusDano < 0)
            {
                return ataqueBase;
            }
            return ataqueBase + bonusDano;
        }
        
        // ==================================================
        // EXEMPLO 2
        // SISTEMA DE PONTUAÇÃO POR MISSÕES
        // Conceitos: for, contador, acumulador e soma.
        // ==================================================
        static int AtualizarPontuacao(int pontuacaoJogador, int qtdMissoes)
        {
            /*
    - Enunciado:
    - Na SA Games, o jogador recebe 100 pontos
    - a cada missão concluída.
             *
    - Crie um método que receba como parâmetros
    - a pontuação atual do jogador e a quantidade
    - de missões concluídas.
             *
    - Utilize uma estrutura de repetição for para
    - percorrer cada missão concluída.
             *
    - A cada missão, adicione 100 pontos à pontuação
    - do jogador e exiba uma mensagem informando:
    - O número da missão concluída;
    - Os pontos recebidos naquela missão;
    - A pontuação total atualizada do jogador.
             *
    - Ao final, retorne a pontuação total do jogador.
             *
    - Exemplos:
             *
    - Entrada:
    - pontuacaoJogador = 50
    - qtdMissoes = 3
             *
    - Saída esperada:
    - Missão 1 | Pontuação: 100 | Total: 150
    - Missão 2 | Pontuação: 100 | Total: 250
    - Missão 3 | Pontuação: 100 | Total: 350
             *
    - Retorno esperado: 350
             */
            if (qtdMissoes <= 0)
            {
                return pontuacaoJogador;
            }

            for (int i = 1; i <= qtdMissoes; i++)
            {
                pontuacaoJogador += 100;

                Console.WriteLine(
                    $"Missão {i} | Pontuação: 100 | Total: {pontuacaoJogador}"
                );
            }

            return pontuacaoJogador;
        }
        
        // ==================================================
        // EXEMPLO 3
        // DIFICULDADE DO INIMIGO
        // Conceitos: if, else if, else e validação de dados.
        // ==================================================
        static string ClassificarInimigo(int nivelInimigo)
        {
            /*
    - Enunciado:
    - A equipe da SA Games precisa determinar a
    - dificuldade de um inimigo de acordo com seu nível.
             *
    - Utilize as seguintes regras:
             *
    - Nível menor ou igual a zero: "Nível inválido"
    - Nível de 1 a 5: "Inimigo Fácil"
    - Nível de 6 a 10: "Inimigo Médio"
    - Nível de 11 a 20: "Inimigo Difícil"
    - Nível acima de 20: "Chefe"
             *
    - Crie um método que receba o nível do inimigo
    - e retorne sua classificação.
             *
    - Exemplos:
    - Entrada: nivelInimigo = 3
    - Saída esperada: "Inimigo Fácil"
             *
    - Entrada: nivelInimigo = 8
    - Saída esperada: "Inimigo Médio"
             *
    - Entrada: nivelInimigo = 15
    - Saída esperada: "Inimigo Difícil"
             *
    - Entrada: nivelInimigo = 25
    - Saída esperada: "Chefe"
             *
    - Entrada: nivelInimigo = 0
    - Saída esperada: "Nível inválido"
             */
            if (nivelInimigo <= 0){
                return "Nível inválido";
            } else if (nivelInimigo <= 5){
                return "Inimigo Fácil";
            } else if (nivelInimigo <= 10){
                return "Inimigo Médio";
            } else if (nivelInimigo <= 20){
                return "Inimigo Difícil";
            } else {
                return "Chefe";
            }
        }
    }
}