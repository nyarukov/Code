#ifndef __BSP_USART_H
#define __BSP_USART_H

#include "stm32f10x.h"

#define DEBUG_USARTX                    USART1
#define DEBUG_USART_CLK                 RCC_APB2Periph_USART1
#define DEBUG_USART_APBxClkCmd          RCC_APB2PeriphClockCmd
#define DEBUG_USART_BAUDRATE            115200

#define DEBUG_USART_GPIO_CLK            (RCC_APB2Periph_GPIOA)
#define DEBUG_USART_GPIO_APBxClkCmd     RCC_APB2PeriphClockCmd

#define DEBUG_USART_TX_GPIO_PORT        GPIOA
#define DEBUG_USART_TX_GPIO_PIN         GPIO_Pin_9
#define DEBUG_USART_RX_GPIO_PORT        GPIOA
#define DEBUG_USART_RX_GPIO_PIN         GPIO_Pin_10

#define DEBUG_USART_IRQ                 USART1_IRQn
#define DEBUG_USART_IRQHandler          USART1_IRQHandler

#define DEBUG_NVIC_PriorityGroupConfig             NVIC_PriorityGroup_1
#define DEBUG_NVIC_IRQChannel                      USART1_IRQn           
#define DEBUG_NVIC_IRQChannelPreemptionPriority    1                       
#define DEBUG_NVIC_IRQChannelSubPriority           1                               

void USART1_Config(void);
void USART_SendByte(USART_TypeDef* USARTx,uint8_t data);
void USART_SendHalfWord(USART_TypeDef* USARTx,uint16_t data);
void USART_SendString( USART_TypeDef * USARTx, char *str);
void USART_SendArray(USART_TypeDef *USARTx, uint32_t *Array,uint8_t Length);


#endif // !__BSP_USART_H