# unit-tests-c-sharp
Documental de testes unitários em C# para prática e aperfeiçoamento.

*xUnit para praticar testes unitários.*

## Pré-requisitos
- DotNet;
- VSCode.

## Ambiente
Dentro da solução estão os projetos (pelo menos 400 prjs uma sln consegue add).
No PrjConsole foi criado um projeto console:
```
dotnet new console PrjConsole
```

No PrjXUnitTests foi criado um projeto para testes:
```
dotnet new xunit PrjXUnitTests
```

Os dois projetos foram adicionados à sln com o plugin vscode:
- vscode-solution-explorer v0.8.6

Atenção que somente uma solution, se haver mais pode dar inconssistência em CI/CD.

Foi feita à referência do PrjConsole ao PrjXUnitTests.
No ".csproj" fica assim:
```
<ItemGroup>
    <ProjectReference Include="..\PrjConsole\PrjConsole.csproj" />
</ItemGroup>
```

## Refinamento inicial
- Operações de soma, subtração, multiplicação e divisão;
- Regras de negócio:
    - Números inteiros;
    - 2 parâmetros por operação;
    - Sempre retornar as últimas 3 operações.

## Contribuições
Contribuições tornam automações mais incríveis!! Toda contribuição será **imensamente apreciada**:
1. Dê um fork no projeto;
2. Crie sua branch de Feature (`git checkout -b feature/FeatureName`);
3. Add alterações (`git add .`);
4. Commit suas alterações (`git commit -m 'Descrição, depois envie o commit'`);
5. Push para o repositório (`git push origin feature/FeatureName`);
6. Abra um PR (pull request) no gitHub.

Novas classes:
```
dotnet new class -n ClassName
```

Comando de ajuda para Class:
```
dotnet new class -h
```
