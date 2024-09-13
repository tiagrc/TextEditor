# Stopwatch Project

Este é um projeto simples de cronômetro (stopwatch) que oferece três opções principais para o usuário:

Criar Arquivo - Salva o tempo decorrido em um arquivo.
Editar Arquivo - Permite a modificação do conteúdo de um arquivo existente.

Sair do Programa - Encerra o programa.
O projeto utiliza funcionalidades básicas de manipulação de arquivos e gerenciamento de recursos, aproveitando classes e métodos específicos para garantir a eficiência e a robustez do código.

## Funcionalidades
### Criar Arquivo

O usuário pode iniciar um cronômetro e, ao final, salvar o tempo decorrido em um arquivo.
O arquivo é criado no diretório especificado e contém o tempo registrado no formato desejado.
Editar Arquivo

Permite a edição de arquivos existentes, modificando o tempo registrado ou qualquer outro conteúdo.
Utiliza um editor de texto simples para permitir a interação do usuário com o arquivo.
Sair do Programa

Encerra o programa de maneira segura, garantindo que todos os recursos sejam liberados adequadamente.
Tecnologias Utilizadas

### StreamWriter: 
Utilizado para criar e escrever dados em arquivos de texto.

### StreamReader: 
Utilizado para ler dados de arquivos de texto.

### Using: 
Gerencia a alocação e liberação de recursos, garantindo que objetos que utilizam recursos não gerenciados sejam corretamente descartados.

### Path:

Facilita o trabalho com caminhos de arquivos e diretórios, permitindo manipulação e validação de caminhos.

# Resumo das Aprendizagens

### StreamWriter

Uso: Escreve texto em um arquivo. Ideal para criar e gravar dados em arquivos de maneira eficiente.
Aprendizagem: Como usar StreamWriter para criar novos arquivos e escrever neles, além de como tratar exceções que podem ocorrer durante a escrita.

### StreamReader

Uso: Lê texto de um arquivo. Permite acessar e processar o conteúdo de arquivos existentes.
Aprendizagem: Como usar StreamReader para ler o conteúdo de arquivos de forma segura, e como lidar com exceções durante a leitura.

### Using

Uso: Garante que objetos que utilizam recursos não gerenciados sejam corretamente descartados após o uso.

Aprendizagem: A importância de utilizar o bloco using para garantir o fechamento correto de arquivos e a liberação de recursos, evitando vazamentos de memória e outros problemas relacionados.

### Path

Uso: Manipula e valida caminhos de arquivos e diretórios.

Aprendizagem: Como construir caminhos de arquivos de maneira segura e eficaz, e como verificar a existência e a validade dos caminhos antes de realizar operações de leitura e escrita.
_____________________________________

Obrigado por conferir este projeto! 😄