# PIM-8-UNIP
Projeto para compor nota do PIM VIII do curso de Análise e Desenvolvimento de Sistemas na Universidade Paulista

## INTRODUÇÃO
Os avanços tecnológicos das ultimas décadas proporcionaram ao usuário  uma gama imensa de ferramentas para auxílio, aprimoramento, facilitação do trabalho, das relações humanas, do acesso à informação e consequentemente transformou a sociedade na Sociedade da Informação, conceito definido por Manuel Castells como:
  - […]organização social em que a geração, o processamento e a transmissão de informação tornam-se as fontes fundamentais de produtividade e poder devido às novas   condições tecnológicas surgidas nesse período histórico[...] (CASTELLS, 2000, p. 65 apud Montoya-Mogollón e Madio, 2018, p. 4167)
  
A criação da internet tratou de ampliar a utilização de sites por pessoas comuns e foi onde o mercado encontrou grande espaço para criar novas relações de consumo com seus consumidores. A disseminação da internet criou um espaço para exploração do mercado em que é possível chegar ao público de forma eficaz, simples e com baixo custo. Em consequência disto, investir em desenvolvimento de software se tornou uma das principais estratégias de negócios para uma empresa se destacar no mercado competitivo.

As técnicas, padrões de projetos, programação orientada à objetos nascem da necessidade, também de aprimorar tecnologias de desenvolvimento de software e atender à grande demanda de mercado, à alta produtividade, às novas tecnologias  e necessidades dos usuários.

Sob esta perspectiva, será desenvolvido parte de um projeto que já se encontra em desenvolvimento na arquitetura MVC, nas plataformas ASP.NET e Xamarin e na linguagem C#. A modelagem do projeto foi desenvolvida permitindo que partes do projeto fosse desenvolvidas em diferentes momentos sem implicar no funcionamento de um primeiro protótipo entregáveis, deste modo será desenvolvido algumas funcionalidades que incluirão uma página web, uma página mobile e a integração do banco de dados às respectivas views baseando-se na arquitetura MVC – Model, View, Controller.



## 1. Referencial Teórico

O desenvolvimento do projeto apoia-se nos conceitos do paradigma da  Orientação a Objetos, na metodologia ágil Scrum para estruturar o desenvolvimento e no padrão de projeto MVC.

### 1.1. Orientação a Objetos
O paradigma orientado a objetos é um dos métodos de programação mais difundidos e e a grande maioria das linguagens de programação modernas são baseadas neste modelo.

A orientação a objetos é construída nos conceitos de classe e objeto que “em resumo: objetos correspondem a elementos da vida real e classes agrupam esses objetos” (FÉLIX, 2016, p.5). Existe ainda alguns outros conceitos da POO, estes caracterizam as classes e definem a relação entre elas.

Os atributos de uma classe são as características que o definem, por exemplo, um carro possui rodas, volante, assento, sem estes “atributos” ele não seria um carro. O conjunto dos atributos de um objeto é chamado de estado do objeto.

Métodos de uma classe são as formas 	que um objeto pode exercer uma ação. O método da classe gato é miar, pois todo o gato possui a ação de miar.

A herança trata-se de um dos principais instrumentos da Orientação a Objetos que permite que uma classe herde atributos de uma outra classe. Por exemplo, um ônibus e um carro são objetos que possuem a roda e o volante como seus principais componentes portanto possuem atributos semelhantes.

Encapsulamento trata-se de uma forma de esconder os atributos da classe disponibilizando apenas os seus métodos. 

O polimorfismo vem do grego – poli = muitas, morphos = forma – e seu conceito quer dizer muitas formas. Desta forma, um objeto pode se comportar de várias formas. Por exemplo, um carro que roda apenas a álcool, não irá funcionar com gasolina, mas um carro. flex irá.
	


### 1.2. Plataforma .NET

A plataforma .NET consiste em um ambiente de desenvolvimento de código aberto e gratuito e multiplataforma. Ele suporta diversas linguagens e pode ser usado para desenvolver softwares para diversos ambientes. Neste projeto, utilizaremos a linguagem C# que é suportada pela plataforma. 

Será utilizado também as plataformas Xamarin e ASP.NET que possuem integração entre si e permitem criar aplicativos mobile e web, respectivamente.
	
### 1.3. Padrões de Projeto

Os padrões de projetos de software preocupam-se em apresentar um modelo de organização e estruturação do projeto que tem como objetivo principal para decompor a complexidade da criação do software.

### 1.3.1. Arquitetura MVC

A arquitetura MVC é o design pattern – padrão de projeto – utilizado no projeto em questão. Trata-se de dividir a estrutura do projeto em 3 partes principais: Model, View e Controller.

A camada Model é a parte da aplicação em que se constrói a comunicação com o banco de dados. A View está diretamente ligada á interface gráfica, ou seja são as páginas do projeto mais próximas do usuário. A Controller é o componente que tem como função intermediar as duas classes anteriores. Enquanto a model fornece os dados e a view fornece a interface, a controller as unifica.

## 2. Escopo do Projeto

O escopo do projeto é o lugar onde se define como devemos realizá-lo apresentando uma análise detalhada com todas as informações necessárias para desenvolver o projeto em questão (CARVALHO, 2012, p.36).

O projeto em questão consiste no desenvolvimento de parte de uma aplicação web que já se encontra em versões iniciais. Será necessário então, desenvolver um mecanismo de acesso ao banco de dados referente ao dados de cadastro de pessoa, tendo também como requisito a construção de uma interface gráfica para web e para mobile.

A tecnologia back-end será desenvolvida na linguagem C#, assim como a tecnologia front-end web e mobile será desenvolvida em ASP.NET e Xamarin respectivamente.

### 2.1. Requisitos

Tendo como o objetivo desenvolver parte de um projeto já em execução, será explicitado aqui apenas os requisitos para tal atividade.
Codificação das classes conforme o diagrama apresentado
- Implementar a lógica de acesso ao banco de dados
- Criar uma interface gráfica web para a  nova funcionalidade do sistema
- Criar uma interface gráfica mobile para a  nova funcionalidade do sistema
- Criar os respectivos campos no banco de dados
    
O sistema deve conter telas de cadastro onde seja possível que o usuário consiga cadastrar, consultar, atualizar e excluir informações do banco de dados.

O diagrama abaixo representa a estrutura das classes que serão desenvolvidas e as características dos dados no banco.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/153727328-47ffad26-d9c0-4b9b-853a-3e50b6c38912.png)
Fonte: Manual do PIM VIII.

### 2.2. Cronograma de Atividades
	
É essencial que se planeje o curso do desenvolvimento das atividades e estimativas a fim de entregar um projeto com qualidade e de forma ágil. Deve-se sempre levar em consideração o contexto em que se encontra a equipe de desenvolvimento, como: capacidade técnica, recursos disponíveis e limitações de diversas origens que impacte na estimativa de tempo de execução do projeto.

Será utilizado a metodologia ágil Scrum como modelo organizacional para as atividades do dia a dia. Através da construção dos Sprints – um trabalho específico que deve ser desenvolvido num determinado tempo – que compõe os backlogs do produto definidos por grau de prioridade. As atividades serão dispostas nos backlogs que serão designados a cada desenvolvedor conforme sua capacidade técnica e o mesmo irá atribuir estimativas com base em sua experiência e levando em conta todo o processo de desenvolvimento do backlog.

O quadro kanban apresenta a esteira de desenvolvimento dos backlogs onde as colunas representam a etapa em que cada backlog se encontra na esteira de desenvolvimento e cada card possui a descrição da atividade a ser desenvolvida possuindo um campo para estimativa, inicio e data limite de entrega. 

![carbarrosmari](https://user-images.githubusercontent.com/85528965/153727322-a004ad55-1e9d-4f64-ba9c-0c3df81f0fe1.png)
Fonte: A autora, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/153727316-5064dbc5-380e-4a41-a06a-4b4661a5ed0d.png)
Fonte: A autora, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/153727312-a59ac13d-940f-441c-a1cc-90caf7dc23a7.png)
Fonte: A autora, 2021.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/153727309-88a652c8-1b35-48f4-9b93-c06abd86a3e0.png)
Fonte: A autora, 2021.

## 3. Protótipo Web

Abaixo é possível observar uma parte do código que constrói a página de interface gráfica com ASP.NET.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/153727306-0f0ef245-4984-4e3f-a94b-246e99db85ac.png)
Fonte: A autora, 2021.

## 4. Acesso ao Banco de Dados

No código abaixo podemos visualizar a conexão com o banco de dados.

![carbarrosmari](https://user-images.githubusercontent.com/85528965/153727297-61c07c52-51bb-49e0-bb8d-f2dabe42ab2a.png)
Fonte: A autora, 2021.

## 5. Conclusão

Este projeto buscou desenvolver as habilidades de front-end e back-end com a linguagem C# através de um formulário de cadastro de pessoa, desenvolvendo cada etapa do projeto, como o escopo, o cronograma com quadro kanban e também foi definido os padrões do projeto.

Sendo assim, vemos a  importância de aplicar design patterns, do planejamento da estimativa de desenvolvimento.
                                                                                                                                       
## 6. Referências

RITTER, Felipe. Desenvolvimento em ASP.NET MVC utilizando Entity Framework. Medianeira. 2011.

FÉLIX, Rafael (org.). Programação orientada a objetos. São Paulo: Pearson Education do Brasil, 2016.

CARVALHO, Fábio Câmara Araújo de. Gestão de Projetos. São Paulo: Pearson Education do Brasil, 2012.

DEITEL, H. M. et al. C# – Como programar. São Paulo: Pearson Education, 2003.

XIX ENCONTRO NACIONAL DE PESQUISA EM CIÊNCIA DA INFORMAÇÃO – ENANCIB, 2018, Londrina. Sociedade da informação: percepções teórico-conceituais. Paraná: 2018.
