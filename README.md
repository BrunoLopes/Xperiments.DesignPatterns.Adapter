##### Design Patterns (Padrões de Projeto)     
[![N|MFYIT](https://contrib.azurewebsites.net/mfyit_card.png)](http://mfyit.azurewebsites.net) 


# Padrão Adapter 

> Adapter (Adaptador, ou também conhecido como Wrapper) é um dos padrões de projeto estruturais do GoF (Gang of Four).

> O padrão Adapter converte uma interface de uma classe para outra interface que o cliente espera encontrar. O Adaptador permite que classes com interfaces incompatíveis trabalhem juntas.

![N|MFYIT](https://upload.wikimedia.org/wikipedia/commons/thumb/4/4e/Adapter_pattern.png/357px-Adapter_pattern.png)


## Descrição das classes de acordo com o diagrama UML 

* Target (Alvo): define a interface do domínio específico que o cliente utiliza.
* Adapter (Adaptador): adapta a interface Adaptee para a interface da classe Target.
* Adaptee (Adaptada): define uma interface existente que necessita ser adaptada.
* Client (Cliente): colabora com os objetos em conformidade com a interface Target.

# Motivação

> Muitas vezes uma classe que poderia ser reaproveitada não é reutilizada justamente pelo fato de sua interface não corresponder à interface específica de um domínio requerida por uma aplicação.

# Aplicabilidade 

O padrão Adapter pode ser utilizado quando:

* se deseja utilizar uma classe existente, porém sua interface não corresponde à interface que se necessita;
* o desenvolvedor quiser criar classes reutilizáveis que cooperem com classes não-relacionadas ou não-previstas, ou seja, classes que não possuem necessariamente interfaces compatíveis;
* (exclusivamente para adaptadores de objetos) é necessário utilizar muitas subclasses existentes, porém, impossível de adaptar essas interfaces criando subclasses para cada uma. Um adaptador de objeto pode adaptar a interface de sua classe mãe.

---

### Installation

- Download the latest .NET Core SDK

* [.NET Core 2.0 SDK](release-notes/download-archives/2.0.3.md)

### Clone

- Clone this repo to your local machine using
```shell
$ git clone https://github.com/BrunoLopes/Xperiments.DesignPatterns.Adapter
```

### Setup

> Restore all the packages first

```shell
$ dotnet restore
```

> now build the project

```shell
$ dotnet build
```
---

## Support

Reach out to me at one of the following places!

- Website:  [![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](http://mfyit.azurewebsites.net)
- Email: emfyit@gmail.com

---

## Donations (Optional)

[![Support via Gratipay](https://cdn.rawgit.com/gratipay/gratipay-badge/2.3.0/dist/gratipay.png)](https://liberapay.com/brunolopes/donate)


---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright MFY IT © 2017  