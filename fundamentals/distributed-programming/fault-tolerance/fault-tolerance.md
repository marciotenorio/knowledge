# Fault Tolerance 

## Strategies To Fault Tolerance

Fault/Falha - Bug\
Error/Erro - Estado incorrendo do sistema, causado pela falha.\
Failure/Defeito - Quando não presta o serviço, desvio do esperado.

### Fases da tolerância:

--- Lidam com o erro no sistema -----
1. Detecção do erro
2. Confinamento do erro e avaliação do dano
3. Recuperação do erro

--- Foco na causa do erro (falha) ---

4. Tratamento da causa e continuidade do serviço

### Técnicas para detecção de erros

- Duplicação e comparação: testes entre implementações iguais/alternativas.
- Checagem de tempo: Execução com base em restrição de tempo. Ex. comum watchdog timer (acho que é heartbeat).
- Checagem reversa: x -> h(x) -> y e y -> h_inversa(x) -> x
- Checagem de codificação: Utiliza informação redundante para checar consistência, como codigo de paridade, checksum, MD5, SHA-1/2, etc.
- Checagem de razoabilidade: Se a resposta não tem algo absurdo como em graus no RN ser -10 Celsius.
- Checagem estrutural: Usado em ds mais complexas, tipo um ponteira na head para 
o ultimo elemento de uma lista ligada.
- Diagnostico: O proprio sistema tem uma bateria de testes para verificar sua integridade.

### Técnicas de confinamento e avaliação de danos
- Ações atômicas
- Operaçoes encapsuladas:
- Isolamento de processos:
- Regras do tipo, tudo que não é permitido é proíbido:
- Controle de recursos:

### Recuperação da falha

Backward error recovery: rollback (um banco de dados)\
Forward error revovery: forward (sinal de tv)

### Tratamento da causa
Lembrar sempre de possíveis side-effects e trata-los.

### Mascaramento
As falhas não aparecem pro usuario (Ação nao pode ser concluida, tente novamente mais tarde, etc). Coisas do tipo

### Mecanismos
Replicação de componentes - hardware, software, informação, etc.\
Códigos de correção de erros - Checksum, etc.\
Programação em N-Versões - Por especificação, empresas distintas, etc.\
Blocos de recuperação - Ideia de transação de bd: begin, commit, rollback, etc.


## Techniques and Practices

- Fault Correlation: identificar padrões entre multiplos eventos, ideia de correlation id, tracing e log, por exemplo. Ideia também de session id, por que pode ter problemas relacionados a um conjunto de coisas feitos na sessão. Transaction id, etc. 

- Error Containment Barrier: evitar propagação. Akka framework. (Dependency command patterns, what is?)

- Verificação completa dos parâmetros: valida-los.

- System monitor: ver sobre cpu, memoria, rede, serviços, etc. Cuidado com o overhead. Aqui entra prometheus, zabbix, etc.

- Heartbeat: Ver se o sistema ta up. O serviço que envia a info.

- Watchdog: Monitora e atua no componente/serviço.

- Realistic Threshold: Limites para uma operaçao normal.

- Leaky Bucket Counter: Contador de falhas. Balanceia falhas com necessidade de intervação. Aparece no circuit breaker.

- Riding Over Transients: Ignorar falhas temporárias. Ex: falha em pacote de transmissão para tv.

- Métrica existentes: Aproveitar métricas para derivar insights e não criar muitas métricas para dar overhead.

- Voting: Mesma pergunta pra serviços, algoritmos, coisas diferentes e ver se eles concordam.

- Manutenção rotineira: prevenir falhas.

- Exercícios rotineiros: testes regulares. 

- Auditorias rotineiras: ver logs, etc coisas do tipo.

- Checksum

- Acknowledgment