// Copyright Epic Games, Inc. All Rights Reserved.

#include "UIFrameworkExamplesGameMode.h"
#include "UIFrameworkExamplesPlayerController.h"
#include "UIFrameworkExamplesCharacter.h"
#include "UObject/ConstructorHelpers.h"

AUIFrameworkExamplesGameMode::AUIFrameworkExamplesGameMode()
{
	// use our custom PlayerController class
	PlayerControllerClass = AUIFrameworkExamplesPlayerController::StaticClass();

	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/TopDownCPP/Blueprints/TopDownCharacter"));
	if (PlayerPawnBPClass.Class != nullptr)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}