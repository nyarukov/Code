#ifndef __BSP_KEY_H
#define __BSP_KEY_H

#include "stm32f10x.h"
#include "Delay.h"

#define SET         1
#define RESET       0 

#define KEY_Mode        GPIO_Mode_IPU
#define KEY_Pin         GPIO_Pin_0
#define KEY_APB2ENR     RCC_APB2Periph_GPIOA
#define KEY_Port_GPIO   GPIOA

void KEY_INIT(void);
uint8_t KEY_GET(void);

#endif // !__BSP_KEY_H