# 📊 Sistema de Gestão Financeira v2.0
[🚀 Clique aqui para ver o Dashboard Visual](index.html)
> **Status do Projeto:** Production Ready 🚀

### 🛠 Stack Tecnológica
* **Backend:** .NET 8.0 (C# 12)
* **Interface:** Swagger / OpenAPI 3.0
* **Arquitetura:** MVC (Model-View-Controller)
* **Versionamento:** Git Flow

---

### 🚀 Performance & Analytics
<div align="center">
  <img src="https://github-readme-stats.vercel.app/api?username=Roger7927&show_icons=true&theme=tokyonight&count_private=true" alt="GitHub Stats" />
  <img src="https://github-readme-stats.vercel.app/api/top-langs/?username=Roger7927&layout=compact&theme=tokyonight" alt="Top Langs" />
</div>

---

### ⚙️ Instruções de Deploy (Ambiente Local)
1. **Restore de Dependências:** `dotnet restore`
2. **Build de Produção:** `dotnet build -c Release`
3. **Execução:** `dotnet run`
4. **Acesso ao Swagger:** `http://localhost:5079/swagger`

---

### 🎯 Funcionalidades Atuais
* **Listagem de Transações:** Retorno de dados financeiros em formato JSON.
* **Roteamento Dinâmico:** Endpoints configurados via Controllers.
* **Estrutura OOP:** Uso de modelos (Classes) para representação de dados reais.

### 📚 Aprendizado (ADS)
* **Web API (ASP.NET Core)**
* **Versionamento de Código (Git/GitHub)**
* **Injeção de Dependências e Middleware**
---

## 🛡️ Atualizações de Infraestrutura e Segurança (Janeiro/2026)
Nesta etapa, foquei em estabilizar a comunicação entre o Frontend (GitHub Pages) e o Backend local, resolvendo gargalos críticos de arquitetura:

* **Correção de CORS:** Implementada política de acesso no `Program.cs` para permitir requisições cross-origin.
* **Ajuste de Endpoints:** Migração e fixação do tráfego para a porta `5100` via `launchSettings.json`.
* **Debug de Conectividade:** Resolução de erro de runtime (Line 25) no servidor Kestrel.
* **Sincronização Ativa:** Dashboard integrado com sucesso, realizando o fetch de dados em tempo real.
