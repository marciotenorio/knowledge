# Arquitetura Orientada A Eventos

## Tratamento de Erros 

### Dead Letter Queue - *DLQ*

Consiste no envio para outra fila/log separada (a DLQ) mensagens que não puderam ser enviadas para outras filas, serviços, não foram processadas corretamenta, perderam TTL, etc para que não sejam perdidas. Redirecionamento feito pelo proprio broker ou middleware.

![DQL Illustration](../../../img/dlq-illustration.png)
Fonte: [redpanda](https://redpanda.com/blog/reliable-message-processing-with-dead-letter-queue)

Na DLQ ela pode ser reprocessada automaticamente, inspecionada para ajudar na correção do problema ou até manualmente reprocessada.
