#include "bsp_exti.h"

static void NVIC_Config(void)
{
    NVIC_InitTypeDef NVIC_InitStruct;

    NVIC_PriorityGroupConfig(NVIC_PriorityGroup_1);

    NVIC_InitStruct.NVIC_IRQChannel = Choose_NVIC_IRQChannel;
    NVIC_InitStruct.NVIC_IRQChannelPreemptionPriority = Choose_NVIC_IRQChannelPreemptionPriority;
    NVIC_InitStruct.NVIC_IRQChannelSubPriority = Choose_NVIC_IRQChannelSubPriority;
    NVIC_InitStruct.NVIC_IRQChannelCmd = ENABLE;
    NVIC_Init(&NVIC_InitStruct);
}

void EXIT_Config(void)
{
    GPIO_InitTypeDef GPIO_InitStruct;
    EXTI_InitTypeDef EXTI_InitStruct;

    NVIC_Config();

    RCC_APB2PeriphClockCmd(RCC_APB2Periph_AFIO|Choose_RCC_GPIO, ENABLE);
    GPIO_InitStruct.GPIO_Mode=Choose_GPIO_Mode;
    GPIO_InitStruct.GPIO_Pin=Choose_GPIO_Pin;
    GPIO_Init(Choose_GPIO_Prot,&GPIO_InitStruct);    

    GPIO_EXTILineConfig(Choose_GPIO_PortSource,Choose_GPIO_PinSource);
    
    EXTI_InitStruct.EXTI_Line = Choose_EXTI_Prot;
    EXTI_InitStruct.EXTI_Mode = Choose_EXTI_Mode;
    EXTI_InitStruct.EXTI_Trigger = Choose_EXTI_Trigger;
    EXTI_InitStruct.EXTI_LineCmd = ENABLE;
    EXTI_Init(&EXTI_InitStruct);

 
}
