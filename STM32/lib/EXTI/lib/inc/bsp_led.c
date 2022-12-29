#include "bsp_led.h"

void LED_INIT(void)
{
    GPIO_InitTypeDef GPIO_InitStruct;
    RCC_APB2PeriphClockCmd(LED_APB2ENR, ENABLE);
    GPIO_InitStruct.GPIO_Mode = LED_Mode;
    GPIO_InitStruct.GPIO_Pin = LED_Pin;
    GPIO_InitStruct.GPIO_Speed = LED_Speed;
    GPIO_Init(LED_Port_GPIO, &GPIO_InitStruct);
    GPIO_SetBits(LED_Port_GPIO,LED_Pin);
}

void LED_ON(uint16_t GPIO_Pin)
{
    GPIO_ResetBits(LED_Port_GPIO, GPIO_Pin);
}
void LED_OFF(uint16_t GPIO_Pin)
{
    GPIO_SetBits(LED_Port_GPIO, GPIO_Pin);
}
void LED_TURN(uint16_t GPIO_Pin)
{
    if (GPIO_ReadOutputDataBit(LED_Port_GPIO, GPIO_Pin) == RESET)
    {
        GPIO_SetBits(LED_Port_GPIO, GPIO_Pin);
    }
    else
    {
        GPIO_ResetBits(LED_Port_GPIO, GPIO_Pin);
    }
}

