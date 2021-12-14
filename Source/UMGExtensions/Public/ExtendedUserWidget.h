// Copyright Dave Ryley. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "Blueprint/UserWidget.h"
#include "ExtendedUserWidget.generated.h"

/**
 *
 */
UCLASS(Abstract)
class UMGEXTENSIONS_API UExtendedUserWidget : public UUserWidget
{
	GENERATED_BODY()

public:
	UExtendedUserWidget(const FObjectInitializer& ObjectInitializer);

};
