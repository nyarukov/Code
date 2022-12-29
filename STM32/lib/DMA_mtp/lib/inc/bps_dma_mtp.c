#include "bps_dma_mtp.h"

uint8_t Buffer[BUFFER_SIZE];

void USART_Config(void)
{
  USART_InitTypeDef USART_InitStruct;
  GPIO_InitTypeDef GPIO_InitStruct;

  RCC_APB2PeriphClockCmd(RCC_APB2Periph_GPIOA, ENABLE);
  RCC_APB2PeriphClockCmd(RCC_APB2Periph_USART1,ENABLE);

  GPIO_InitStruct.GPIO_Pin = GPIO_Pin_9;    //TX
  GPIO_InitStruct.GPIO_Mode = GPIO_Mode_AF_PP;
  GPIO_InitStruct.GPIO_Speed = GPIO_Speed_50MHz;

  GPIO_Init(GPIOA,&GPIO_InitStruct);
  GPIO_InitStruct.GPIO_Pin = GPIO_Pin_10;   //RX
  GPIO_InitStruct.GPIO_Mode = GPIO_Mode_IN_FLOATING;
  GPIO_InitStruct.GPIO_Speed = GPIO_Speed_50MHz;
  GPIO_Init(GPIOA,&GPIO_InitStruct);

  
  USART_InitStruct.USART_BaudRate=115200;
  USART_InitStruct.USART_HardwareFlowControl=USART_HardwareFlowControl_None;
  USART_InitStruct.USART_Mode=USART_Mode_Rx|USART_Mode_Tx;
  USART_InitStruct.USART_Parity=USART_Parity_No;
  USART_InitStruct.USART_StopBits=USART_StopBits_1;
  USART_InitStruct.USART_WordLength=USART_WordLength_8b;
  
  USART_Init(USART1,&USART_InitStruct);
  USART_Cmd(USART1,ENABLE);
  
}
void USART_MTP_Config(void)
{
  DMA_InitTypeDef DMA_InitStruct;
  RCC_AHBPeriphClockCmd(RCC_AHBPeriph_DMA1,ENABLE);

  DMA_InitStruct.DMA_BufferSize=BUFFER_SIZE;
  DMA_InitStruct.DMA_DIR=DMA_DIR_PeripheralDST;
  DMA_InitStruct.DMA_M2M=DMA_M2M_Disable;
  DMA_InitStruct.DMA_MemoryBaseAddr=(u32)Buffer;
  DMA_InitStruct.DMA_PeripheralBaseAddr=(USART1_BASE+0x04);
  DMA_InitStruct.DMA_MemoryDataSize=DMA_MemoryDataSize_Byte;
  DMA_InitStruct.DMA_PeripheralDataSize=DMA_PeripheralDataSize_Byte;
  DMA_InitStruct.DMA_MemoryInc=DMA_MemoryInc_Enable;
  DMA_InitStruct.DMA_PeripheralInc=DMA_PeripheralInc_Disable;
  DMA_InitStruct.DMA_Mode=DMA_Mode_Normal;
  DMA_InitStruct.DMA_Priority=DMA_Priority_High;

  DMA_Init(DMA1_Channel4,&DMA_InitStruct);
  DMA_ClearFlag(DMA1_FLAG_TC4);
  DMA_Cmd(DMA1_Channel4,ENABLE);
}

