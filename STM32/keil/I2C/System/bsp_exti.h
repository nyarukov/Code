#ifndef __BSP_EXIT_H
#define __BSP_EXIT_H

#include "stm32f10x.h"

#define DEBUG_RCC_GPIO                             RCC_APB2Periph_GPIOA     //时钟端口
#define DEBUG_GPIO_Mode                            GPIO_Mode_IPU           //引脚模式
#define DEBUG_GPIO_Pin                             GPIO_Pin_0              //引脚端口
#define DEBUG_GPIO_Prot                            GPIOA                   //初始化GPIO端口

#define DEBUG_GPIO_PortSource                      GPIO_PortSourceGPIOA    //EXTI信号源
#define DEBUG_GPIO_PinSource                       GPIO_PinSource0         

#define DEBUG_EXTI_Prot                            EXTI_Line0              //中断/事件线
#define DEBUG_EXTI_Mode                            EXTI_Mode_Interrupt     //模式
#define DEBUG_EXTI_Trigger                         EXTI_Trigger_Rising     //端口检测方式

#define DEBUG_PriorityGroupConfig                  NVIC_PriorityGroup_1    //配置优先分组

#define DEBUG_NVIC_IRQChannel                      EXTI0_IRQn              //中断源
#define DEBUG_NVIC_IRQChannelPreemptionPriority    1                       //抢占优先级
#define DEBUG_NVIC_IRQChannelSubPriority           1                        //子优先级          

void EXIT_Config(void);

#endif // !__BSP_EXIT_H
