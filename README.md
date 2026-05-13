# DesafioAMcom

Durante esse Desafio, através do teste técnico você será avaliado nos seguintes requisitos:

- Conhecimento Linguagem Programação C#;
- Princípios S.O.L.I.D e Clean Code;
- Habilidade de escrever testes unitários;
- Capacidade de identificar e resolver problemas;
- Refatoração de código;

Para atender o nosso cliente precisamos resolver alguns problemas e desenvolver novas funcionalidades na aplicação atual.
O aplicativo é uma WebAPI desenvolvida em .NET 10 e estamos com problemas para identificar falhas na API e ao salvar as temperaturas erros estão acontecendo.

1)	Retornar a lista de países como origem o arquivo ‘países.json’ e disponibilizar as informações em um endpoint.
2)	Verificar o Controller de Temperaturas e verificar itens para serem melhorados e consertados.
3)	Cálculos de temperaturas já existentes não precisam ser mais calculados, devem ser armazenados (cache) e retornar o cálculo.
4)	Retornar dados da API https://reqres.in/api/users?page=2 e aplicar filtros para buscar pessoas por email e/ou nome.
5)	Documente os endpoints no Swagger
6)	Implemente Polly para Requests Http.
7)	Publique seu código em um repositório 😊
8)	Crie uma imagem Docker do seu aplicativo e publique lá no Docker Hub.

![alt text](image.png)

<img width="1536" height="1024" alt="Copilot_20260513_052547" src="https://github.com/user-attachments/assets/c09af244-1abd-40a5-b036-57afe2df29d6" />

🔹 Fluxo de execução detalhado:
1) Cliente (Front-End / Mobile) → envia requisição HTTP.
2) Camada de Apresentação (WebApi) → o Controller recebe a requisição, valida e encaminha para o Service.
3) Camada de Aplicação (Application) → o Service processa a lógica de negócio, consulta o domínio e, se necessário, acessa infraestrutura (cache, API externa, JSON).
4) Camada de Domínio (Domain) → contém as entidades e regras fundamentais (ex: Temperature, Country, User).
5) Camada de Infraestrutura (Infrastructure) → executa operações técnicas (cache, leitura de arquivo, requisições HTTP com Polly).
6) Camada de Testes e Deploy → valida os serviços e publica via Docker.
7) Resposta → retorna ao cliente via Controller.



