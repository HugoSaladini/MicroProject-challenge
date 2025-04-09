# Simulador de Micro-ondas

![GitHub repo size](https://img.shields.io/github/repo-size/HugoSaladini/MicroProject-challenge)
![GitHub language count](https://img.shields.io/github/languages/count/HugoSaladini/MicroProject-challenge)
![GitHub top language](https://img.shields.io/github/languages/top/HugoSaladini/MicroProject-challenge)

Este projeto é um simulador de micro-ondas desenvolvido com .NET Core (Razor Pages) C#. O objetivo é simular funcionalidades de um micro-ondas, de acordo com requisitos pré estabelecidos para a aplicação do Teste de Orientação a Objeto

## 🚀 Tecnologias Utilizadas

- .NET 8
- C#
- Razor Pages
- HTML/CSS

## ▶️ Como Rodar o Projeto Localmente

### ✅ Pré-requisitos

- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download) ou superior  
- Editor de código (recomendado: [Visual Studio 2022+](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/))

### 🧪 Passos para Executar

1. Clone o repositório:  
   `git clone https://github.com/HugoSaladini/MicroProject-challenge.git`

2. Navegue até o diretório do projeto:  
   `cd MicroProject-challenge`

3. Restaure as dependências:  
   `dotnet restore`

4. Execute o projeto:  
   `dotnet run --project MicroOndas.Web/MicroOndas.Web.csproj`

> ⚠️ **Observação:**  
> Nesta etapa, podem ocorrer erros relacionados a versões ou dependências do projeto. Siga os passos abaixo para validar e corrigir possíveis problemas:

### ✅ Passos para validação e correção

1. Verifique se o arquivo `MicroOndasProject.sln` está localizado na raiz do projeto, caso esteja, execute ele.

2. No projeto `MicroOndas.Web`, certifique-se de que a dependência de inicialização esteja corretamente referenciando o projeto `MicroOndas.Domain`.
 
    ![image](https://github.com/user-attachments/assets/5cf20620-0fe0-4dea-b89e-5a8111c3d89b)

3. Clique com o botão direito na **solução `MicroOndasProject`** e selecione:
   - `Limpar Solução`
   - `Recompilar Solução`


6. Acesse a aplicação no navegador:  
   `http://localhost`

## 📁 Estrutura do Projeto

- `MicroOndas.Domain/` – Camada de domínio com as entidades e lógica de negócio  
- `MicroOndas.Tests/` – Projeto de testes automatizados  
- `MicroOndas.Web/` – Projeto principal com Razor Pages
## 🔧 Funcionalidades

- Simulação de tempo com contador regressivo em tempo real  
- Controle de potência ajustável para o aquecimento  
- Programas de aquecimento pré-configurados  
- Criação e utilização de programas personalizados  
- Entrada de tempo via teclado físico ou na interface

##

![image](https://github.com/user-attachments/assets/4769c0eb-a6bd-4ed3-bbbd-10bfa88c4acd)


