#include "stm32f10x_gpio.h"

void GPIO_SetBit(GPIO_TypeDef *GPIOX,U16 GPIO_Pin){
    GPIOX->BSRR |=GPIO_Pin;
}
void GPIO_ResetBit(GPIO_TypeDef *GPIOX,U16 GPIO_Pin){
    GPIOX->BRR &=~GPIO_Pin;
}