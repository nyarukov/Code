#include "stm32f10x.h"
#include "stm32f10x_gpio.h"

int main(void)
{

  RCC->APB2ENR |= (1 << 3);
  GPIOB->CRL |= ((3) << (4 * 1));

  //GPIO_ResetBit(GPIOB, GPIO_Pin_1);
   GPIO_SetBit(GPIOB, GPIO_Pin_1);
}

void SystemInit(void)
{
}