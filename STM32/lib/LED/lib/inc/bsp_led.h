#ifndef __BSP_LED_H
#define __BSP_LED_H

#include "stm32f10x.h"

#define SET         1
#define RESET       0 

#define LED_Mode    GPIO_Mode_Out_PP
#define LED_Pin     GPIO_Pin_1
#define LED_Speed   GPIO_Speed_50MHz
#define LED_APB2ENR     RCC_APB2Periph_GPIOB
#define LED_Port_GPIO   GPIOB

void LED_INIT(void);
void LED_ON(void);
void LED_OFF(void);
void LED_TURN(void);

#endif // !__BSP_LED_H