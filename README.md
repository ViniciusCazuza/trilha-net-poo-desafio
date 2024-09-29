# Desafio de Código .NET | C# ( POO ) ( CRUD ) - Sistema de Smartphone

## Descrição
Este projeto é um sistema de gerenciamento de smartphones que permite aos usuários interagir com aplicativos, incluindo funcionalidades de instalação e desinstalação de apps, com base em uma estrutura de classes que implementa princípios de Orientação a Objetos (OOP).

## Funcionalidades
- **Cadastro de Smartphones**: Criação de diferentes modelos de smartphones (iPhone e Nokia) com atributos como marca, modelo, número, IMEI, memória e status.
- **App Store**: Um menu para instalar e desinstalar aplicativos de diferentes categorias:
  - Apps de Mensagem
  - Apps de Música
  - Apps de Fotos e Vídeos
  - Apps de Redes Sociais
- **CRUD de Aplicativos**: 
  - **Create**: Instalar novos aplicativos.
  - **Read**: Listar aplicativos disponíveis para instalação.
  - **Update**: Atualizar informações, como o nome do Smartphone (Ex. iPhone de Vinicius => iPhone de Cazuza).
  - **Delete**: Desinstalar aplicativos.

## Tecnologias Utilizadas
- **C#**: Linguagem principal do projeto.
- **Newtonsoft.Json**: Biblioteca para manipulação de dados em formato JSON.
- **Estrutura de Classes**: Utilização de herança e polimorfismo para a criação de diferentes tipos de smartphones.

## Estrutura do Projeto
- `Models/Smartphone.cs`: Classe base para smartphones.
- `Models/Iphone.cs`: Classe que herda de `Smartphone` e implementa funcionalidades específicas do iPhone.
- `Models/Nokia.cs`: Classe que herda de `Smartphone` e implementa funcionalidades específicas do Nokia.
- `AppStore`: Classe responsável pela gestão de aplicativos.

## Instruções para Teste
1. **Clone o Repositório**
   ```bash
   git clone https://github.com/ViniciusCazuza/trilha-net-poo-desafio
   cd <nome_do_diretório>

#### Instale as Dependências
## Instalação do Newtonsoft.Json

Para utilizar a biblioteca Newtonsoft.Json, siga os passos abaixo:

1. **Abra o Terminal do Visual Studio**:
   - Vá até o menu `View` e selecione `Terminal` ou use o atalho `Ctrl + '` (Ctrl + tecla de aspas simples).

2. **Navegue até o Diretório do Projeto**:
   ```bash
   cd <nome_do_diretório>
Instale o Newtonsoft.Json: Execute o seguinte comando:


3. **Copiar código**:
    ```bash
    dotnet add package Newtonsoft.Json
Aguarde a Conclusão da Instalação: O terminal irá baixar e instalar a biblioteca. Após a conclusão, você estará pronto para usá-la em seu projeto.

#### Certifique-se de ter o .NET SDK instalado.

4. **Execute o Projeto**:
    ```bash
    dotnet run
Interaja com o Sistema

Siga as instruções apresentadas no console para navegar pelo menu e testar as funcionalidades do sistema.

### Contribuições:
#### Sinta-se à vontade para abrir issues ou enviar pull requests para melhorias e correções!

**Manutenção e Evolução**:
Continuarei em constante manutenção e evolução neste projeto, implementando mais funcionalidades, melhorias e correções.

##

# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.