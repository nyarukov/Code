#include "bsp_exti.h"

static void NVIC_Config(void)
{
    NVIC_InitTypeDef NVIC_InitStruct;

    NVIC_PriorityGroupConfig(NVIC_PriorityGroup_1);

    NVIC_InitStruct.NVIC_IRQChannel = DEBUG_NVIC_IRQChannel;
    NVIC_InitStruct.NVIC_IRQChannelPreemptionPriority = DEBUG_NVIC_IRQChannelPreemptionPriority;
    NVIC_InitStruct.NVIC_IRQChannelSubPriority = DEBUG_NVIC_IRQChannelSubPriority;
    NVIC_InitStruct.NVIC_IRQChannelCmd = ENABLE;
    NVIC_Init(&NVIC_InitStruct);
}

void EXIT_Config(void)
{
    GPIO_InitTypeDef GPIO_InitStruct;
    EXTI_InitTypeDef EXTI_InitStruct;

    NVIC_Config();

    RCC_APB2PeriphClockCmd(RCC_APB2Periph_AFIO|DEBUG_RCC_GPIO, ENABLE);
    GPIO_InitStruct.GPIO_Mode=DEBUG_GPIO_Mode;
    GPIO_InitStruct.GPIO_Pin=DEBUG_GPIO_Pin;
    GPIO_Init(DEBUG_GPIO_Prot,&GPIO_InitStruct);    

    GPIO_EXTILineConfig(DEBUG_GPIO_PortSource,DEBUG_GPIO_PinSource);
    
    EXTI_InitStruct.EXTI_Line = DEBUG_EXTI_Prot;
    EXTI_InitStruct.EXTI_Mode = DEBUG_EXTI_Mode;
    EXTI_InitStruct.EXTI_Trigger = DEBUG_EXTI_Trigger;
    EXTI_InitStruct.EXTI_LineCmd = ENABLE;
    EXTI_Init(&EXTI_InitStruct);

 
}
