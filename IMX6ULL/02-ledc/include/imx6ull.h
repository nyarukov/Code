#ifndef __IMX6ULL_H
#define __IMX6ULL_H

#define CCM_BASE                (0X020C4000)
#define IOMUXC_GPR_BASE         (0X020E4000)
#define IOMUXC_SNVS_BASE        (0X02290000)
#define IOMUXC_SW_MUX_BASE      (0X020E0044)
#define IOMUXC_SW_PAD_BASE      (0X020E0204)
#define GPIO1_BASE              (0X0209C000)
#define GPIO2_BASE              (0X0209C014)
#define GPIO3_BASE              (0X020A4000)
#define GPIO4_BASE              (0X020A8000)
#define GPIO5_BASE              (0X020AC000)

#define _IO             volatile unsigned int
#define uint8_t         volatile unsigned char


#include "iomux.h"
#include "gpio.h"
#include "ccm.h"

#endif // !__IMX6ULL_H