# Simulador de Micro-ondas

Este projeto é um simulador de micro-ondas desenvolvido com **ASP.NET Core** (Razor Pages) no backend e **JavaScript** no frontend. O objetivo é simular funcionalidades reais de um micro-ondas, incluindo teclado numérico, aquecimento com potência, pausa, cancelamento, e lógica de aquecimento visual.

---

## Tecnologias Utilizadas

- [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- ASP.NET Core (Razor Pages)
- JavaScript (Vanilla)
- HTML/CSS

---

## 📦 Como rodar o projeto localmente

### ✅ Pré-requisitos

- [.NET SDK 8.0+](https://dotnet.microsoft.com/en-us/download)
- Editor de código (recomendado: [Visual Studio 2022+](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/))

### 🔧 Passos para executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/simulador-microondas.git
   cd simulador-microondas

   dotnet restore

   dotnet run

   https://localhost:7202

   
   MicroOndas/
    │
    ├── Pages/
    │   └── Index.cshtml            # Interface do usuário
    │   └── Index.cshtml.cs         # Código-behind da página
    │
    ├── Services/
    │   └── AquecimentoService.cs   # Regras de negócio do aquecimento
    │   └── AquecimentoState.cs     # Estado global do aquecimento (em desenvolvimento)
    │
    ├── Program.cs                  # Configuração de endpoints e serviços
    ├── wwwroot/                    # Scripts e estilos estáticos
    └── README.md                   # Documentação do projeto

   ```
## 💡 Funcionalidades Implementadas

- ✅ **Inserção de tempo manual ou via teclado digital (botões numéricos)**
- ✅ **Aquecimento com tempo e potência definidos**
- ✅ **Início rápido** (30s e potência 10 ao apertar "Iniciar" sem preencher campos)
- ✅ **Exibição do tempo restante em tempo real**
- ✅ **Exibição visual do progresso do aquecimento** com `.` por segundo de acordo com a potência
- ✅ **Interrupção do aquecimento**
- ✅ **Retorno de informações via**

