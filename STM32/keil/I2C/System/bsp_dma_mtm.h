#ifndef __BSP_DMA_MTM_H
#define __BSP_DMA_MTM_H

#include "stm32f10x.h"

#define BUFFER_SIZE 32

void MtM_DMA_Config(void);
uint8_t BufferData_Cmp(const uint32_t* pBuffer,uint32_t* pBuffer1,uint16_t BuffferLength);

#endif // !__BSP_DMA_MTM_H
