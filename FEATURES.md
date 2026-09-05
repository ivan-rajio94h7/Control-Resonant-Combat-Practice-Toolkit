# CONTROL Resonant: Feature Scope

Status: Prerelease module plan. Checked 2026-09-05.

The items below are proposed capabilities. They are not release notes or a list of working features.

## Combat assistance

Research bounded damage assistance once the released game's combat values are understood.

Acceptance: identify the supported game build and affected state; demonstrate the intended result; test transitions and persistence; document the original value or baseline and any restoration limits.

## Ability profiles

Plan readable ability configurations without assuming an unconfirmed skill tree or resource model.

Acceptance: identify the supported game build and affected state; demonstrate the intended result; test transitions and persistence; document the original value or baseline and any restoration limits.

## Encounter pacing

Investigate adjustable practice speed and check its effect on animations and scripted events.

Acceptance: identify the supported game build and affected state; demonstrate the intended result; test transitions and persistence; document the original value or baseline and any restoration limits.

## Progression budgets

Prepare a module interface for verified progression resources; exact resource names remain unassigned.

Acceptance: identify the supported game build and affected state; demonstrate the intended result; test transitions and persistence; document the original value or baseline and any restoration limits.

## Practice snapshots

Explore encounter restoration after the released save structure and checkpoint behaviour are documented.

Acceptance: identify the supported game build and affected state; demonstrate the intended result; test transitions and persistence; document the original value or baseline and any restoration limits.

## Build-specific support

Require a tested game version beside every eventual feature and keep unsupported options unavailable.

Acceptance: identify the supported game build and affected state; demonstrate the intended result; test transitions and persistence; document the original value or baseline and any restoration limits.

## Shared application architecture

This theme is one adapter for a common application. The shared interface can manage profiles and show change previews; each game adapter must implement and validate its own behaviour. No universal memory addresses, item identifiers, save paths or hotkeys are supplied.

## Session scope

The proposed game-state assistance is scoped to the single-player game. Profile restoration must account for the complete relevant state, including any separate world and character data.

## First implementation target

After the PC release, a player could rehearse an encounter with limited assistance and reduce it on later attempts. This package describes that experience without claiming that an operational module already exists.
