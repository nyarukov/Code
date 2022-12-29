#ifndef __BSP_LED_H
#define __BSP_LED_H

#include "stm32f10x.h"

#define SET         1
#define RESET       0 

#define LED_Mode    GPIO_Mode_Out_PP
#define LED_Pin     GPIO_Pin_10 | GPIO_Pin_11
#define LED_Speed   GPIO_Speed_50MHz
#define LED_APB2ENR     RCC_APB2Periph_GPIOB
#define LED_Port_GPIO   GPIOB

void LED_INIT(void);
void LED_ON(uint16_t GPIO_Pin);
void LED_OFF(uint16_t GPIO_Pin);
void LED_TURN(uint16_t GPIO_Pin);

#endif // !__BSP_LED_H