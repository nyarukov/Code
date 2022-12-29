#ifndef __STM32F10X_H
#define __STM32F10X_H

#define PERIPH_BASE     0X40000000
#define APB1_BASE       PERIPH_BASE
#define APB2_BASE       ((PERIPH_BASE)+0X10000)
#define AHB_BASE        ((PERIPH_BASE)+0X20000)

#define RCC_BASE        ((AHB_BASE)+0X1000)

typedef unsigned char    U8;
typedef unsigned short   U16;
typedef unsigned int     U32;
typedef unsigned long    U64;

typedef  char    Int8;
typedef  short   Int16;
typedef  int     Int32;
typedef  long    Int64;

typedef struct 
{
    U32 CR;
    U32 CFGR;
    U32 CIR;
    U32 APB2RSTR;
    U32 APB1RSTR;
    U32 AHBENR;
    U32 APB2ENR;
    U32 APB1ENR;
    U32 BDCR;
    U32 CSR;
}RCC_TYpeDef;
#define RCC     ((RCC_TYpeDef*)RCC_BASE)

#define AFIO_BASE    ((APB2_BASE)+0X0000)
#define GPIOA_BASE   ((APB2_BASE)+0X0800)
#define GPIOB_BASE   ((APB2_BASE)+0X0C00)
#define GPIOC_BASE   ((APB2_BASE)+0X1200)
#define GPIOD_BASE   ((APB2_BASE)+0X1400)
#define GPIOE_BASE   ((APB2_BASE)+0X1800)
#define GPIOF_BASE   ((APB2_BASE)+0X1C00)
#define GPIOG_BASE   ((APB2_BASE)+0X2000)
#define ADC1_BASE    ((APB2_BASE)+0X2400)
#define ADC2_BASE    ((APB2_BASE)+0X2800)
#define TIM1_BASE    ((APB2_BASE)+0X2C00)
#define SPI1_BASE    ((APB2_BASE)+0X3000)
#define TIM8_BASE    ((APB2_BASE)+0X3400)
#define USART1_BASE  ((APB2_BASE)+0X3800)
#define ADC3_BASE    ((APB2_BASE)+0X3C00)

typedef struct 
{
    U32 CRL;
    U32 CRH;
    U32 IDR;
    U32 ODR;
    U32 BSRR;
    U32 BRR;
    U32 LCKR;
}GPIO_TypeDef;

#define GPIOA       ((GPIO_TypeDef*)GPIOB_BASE)
#define GPIOB       ((GPIO_TypeDef*)GPIOB_BASE)
#define GPIOC       ((GPIO_TypeDef*)GPIOB_BASE)
#define GPIOD       ((GPIO_TypeDef*)GPIOB_BASE)
#define GPIOE       ((GPIO_TypeDef*)GPIOB_BASE)
#define GPIOF       ((GPIO_TypeDef*)GPIOB_BASE)
#define GPIOG       ((GPIO_TypeDef*)GPIOB_BASE)


#endif // !__STM32F10X_H