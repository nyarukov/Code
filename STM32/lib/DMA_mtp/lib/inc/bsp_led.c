#include "bsp_led.h"

void LED_Config(void)
{
    GPIO_InitTypeDef GPIO_InitStruct;
    DEBUG_GPIO_Cmd(DEBUG_GPIO_CLK, ENABLE);
    GPIO_InitStruct.GPIO_Mode = DEBUG_GPIO_Mode;
    GPIO_InitStruct.GPIO_Pin = DEBUG_GPIO_Pin;
    GPIO_InitStruct.GPIO_Speed = DEBUG_GPIO_Speed;
    GPIO_Init(DEBUG_GPIO_Port, &GPIO_InitStruct);
    GPIO_SetBits(DEBUG_GPIO_Port ,DEBUG_GPIO_Pin);
}

void LED_ON(uint16_t GPIO_Pin)
{
    GPIO_ResetBits(DEBUG_GPIO_Port , GPIO_Pin);
}
void LED_OFF(uint16_t GPIO_Pin)
{
    GPIO_SetBits(DEBUG_GPIO_Port , GPIO_Pin);
}
void LED_TURN(uint16_t GPIO_Pin)
{
    if (GPIO_ReadOutputDataBit(DEBUG_GPIO_Port, GPIO_Pin) == RESET)
    {
        GPIO_SetBits(DEBUG_GPIO_Port, GPIO_Pin);
    }
    else
    {
        GPIO_ResetBits(DEBUG_GPIO_Port, GPIO_Pin);
    }
}

