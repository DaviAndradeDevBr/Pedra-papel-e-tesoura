# Pedra, Papel e Tesoura 

## Introdução
Este projeto é uma implementação em **C#** do clássico jogo **Jokenpô**, desenvolvido durante o curso Fullstack da **Academia do Programador**. O sistema permite que um usuário jogue contra o computador através do console, utilizando lógica de condições para determinar o vencedor de cada rodada.


## Funcionalidades 🎯
O funcionamento segue a lógica tradicional:
- **Pedra** vence Tesoura.
- **Tesoura** vence Papel.
- **Papel** vence Pedra.
- Escolhas idênticas resultam em **Empate**.

O computador realiza uma escolha aleatória a cada rodada, garantindo a imprevisibilidade da partida.

---

## Instruções de Uso 💻

1.  Obtenha o código via clone de repositório ou download do arquivo `.zip`.
2.  Acesse o diretório raiz através do terminal.

3.  **Utilize o comando abaixo para restaurar as dependências:**
    ```bash
    dotnet restore
    ```

4.  **Inicie a aplicação:**
    ```bash
    dotnet run --project PedraPapelTesoura.ConsoleApp
    ```

## Requisitos de Sistema

.NET SDK 10.0 ou superior.