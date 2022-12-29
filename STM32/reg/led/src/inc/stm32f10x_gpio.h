#ifndef __STM32F10X_GPIO_H
#define __STM32F10X_GPIO_H

#include "stm32f10x.h"

#define GPIO_Pin_0     ((U16)0X0001) 
#define GPIO_Pin_1     ((U16)0X0002) 
#define GPIO_Pin_2     ((U16)0X0004) 
#define GPIO_Pin_3     ((U16)0X0008) 
#define GPIO_Pin_4     ((U16)0X0010) 
#define GPIO_Pin_5     ((U16)0X0020) 
#define GPIO_Pin_6     ((U16)0X0040) 
#define GPIO_Pin_7     ((U16)0X0080) 
#define GPIO_Pin_8     ((U16)0X0100) 
#define GPIO_Pin_9     ((U16)0X0200) 
#define GPIO_Pin_10    ((U16)0X0400) 
#define GPIO_Pin_11    ((U16)0X0800) 
#define GPIO_Pin_12    ((U16)0X1000) 
#define GPIO_Pin_13    ((U16)0X2000) 
#define GPIO_Pin_14    ((U16)0X4000) 
#define GPIO_Pin_15    ((U16)0X8000) 
#define GPIO_Pin_All   ((U16)0XFFFF) 


void GPIO_SetBit(GPIO_TypeDef *GPIOX,U16 GPIO_Pin);
void GPIO_ResetBit(GPIO_TypeDef *GPIOX,U16 GPIO_Pin);

#endif // !__STM32F10X_GPIO_H