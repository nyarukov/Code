#include "bsp_usart.h"

// static void NVIC_Config(void)
// {
//     NVIC_InitTypeDef NVIC_InitStruct;

//     NVIC_PriorityGroupConfig(DEBUG_NVIC_PriorityGroupConfig);

//     NVIC_InitStruct.NVIC_IRQChannel = DEBUG_NVIC_IRQChannel;
//     NVIC_InitStruct.NVIC_IRQChannelPreemptionPriority = DEBUG_NVIC_IRQChannelPreemptionPriority;
//     NVIC_InitStruct.NVIC_IRQChannelSubPriority = DEBUG_NVIC_IRQChannelSubPriority;
//     NVIC_InitStruct.NVIC_IRQChannelCmd = ENABLE;
//     NVIC_Init(&NVIC_InitStruct);
// }

void USART1_Config(void)
{
    GPIO_InitTypeDef GPIO_InitStruct;
    USART_InitTypeDef USART_InitStruct;
    //串口引脚GPIO时钟
    DEBUG_USART_GPIO_APBxClkCmd(DEBUG_USART_GPIO_CLK, ENABLE);
    //串口时钟
    DEBUG_USART_APBxClkCmd(DEBUG_USART_CLK, ENABLE);
    //配置Tx的GPIO引脚模式
    GPIO_InitStruct.GPIO_Mode = GPIO_Mode_AF_PP;
    GPIO_InitStruct.GPIO_Pin = DEBUG_USART_TX_GPIO_PIN;
    GPIO_InitStruct.GPIO_Speed = GPIO_Speed_50MHz;
    GPIO_Init(DEBUG_USART_TX_GPIO_PORT, &GPIO_InitStruct);
    //配置Rx的GPIO引脚模式
    GPIO_InitStruct.GPIO_Mode = GPIO_Mode_IN_FLOATING;
    GPIO_InitStruct.GPIO_Pin = DEBUG_USART_RX_GPIO_PIN;
    GPIO_InitStruct.GPIO_Speed = GPIO_Speed_50MHz;
    GPIO_Init(DEBUG_USART_RX_GPIO_PORT, &GPIO_InitStruct);
    //串口工作模式
    //波特率
    USART_InitStruct.USART_BaudRate = DEBUG_USART_BAUDRATE;
    //数据位
    USART_InitStruct.USART_WordLength = USART_WordLength_8b;
    //停止位
    USART_InitStruct.USART_StopBits = USART_StopBits_1;
    //校验位
    USART_InitStruct.USART_Parity = USART_Parity_No;
    //硬件流
    USART_InitStruct.USART_HardwareFlowControl = USART_HardwareFlowControl_None;
    //工作模式
    USART_InitStruct.USART_Mode = USART_Mode_Tx | USART_Mode_Rx;
    USART_Init(DEBUG_USARTX, &USART_InitStruct);
    //串口优先级
    //NVIC_Config();
    //使能串口接收中断
    //USART_ITConfig(DEBUG_USARTX, USART_IT_RXNE, ENABLE);
    //使能串口
    USART_Cmd(DEBUG_USARTX, ENABLE);
}

void USART_SendByte(USART_TypeDef *USARTx, uint8_t data)
{
    USART_SendData(USARTx, data);
    while (USART_GetFlagStatus(USARTx, USART_FLAG_TXE) == RESET);
}
void USART_SendHalfWord(USART_TypeDef *USARTx, uint16_t data)
{
    uint8_t tmpe_H, tmpe_L;
    tmpe_H = ((data >> 8) & (0XFF));
    tmpe_L = data & (0XFF);
    USART_SendData(USARTx, tmpe_H);
    while (USART_GetFlagStatus(USARTx, USART_FLAG_TXE) == RESET);
    USART_SendData(USARTx, tmpe_L);
    while (USART_GetFlagStatus(USARTx, USART_FLAG_TXE) == RESET);
}

void USART_SendArray(USART_TypeDef* USARTx, uint32_t* Array,uint8_t Length)
{ 
    for (uint16_t i = 0; i < Length; i++)
    {
        USART_SendByte(USARTx,Array[i]);
    }
}
void USART_SendString( USART_TypeDef* USARTx, char* str)
{
 while( *str!='\0' )
 {
	USART_SendByte( USARTx, *str++); 
 }
 while (USART_GetFlagStatus(USARTx, USART_FLAG_TC)== RESET);
}

