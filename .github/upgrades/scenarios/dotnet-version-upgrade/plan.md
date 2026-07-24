# .NET Version Upgrade Plan

## Overview

**Target**: Upgrade projects in the solution to net10.0
**Scope**: Projects targeting .NET 6 across the solution: TodoList\BlazorApp, BlazorComponent.Tests, MvcWebApp, SpecFlowProject (as identified in assessment)

## Tasks

### 01-update-project-tfms: Update project target frameworks to net10.0

Update each project's TargetFramework/TargetFrameworks to net10.0 and ensure project files use SDK-style settings where applicable.

**Done when**: All projects previously targeting net6.0 report net10.0 as their TargetFramework in the csproj, and the solution builds without errors.

---

### 02-update-nuget-packages: Update NuGet packages to compatible versions

Update deprecated or incompatible NuGet packages to versions that support net10.0 (or find suitable replacements). Pay special attention to packages flagged in assessment.

**Done when**: All package updates applied, projects build clean, and tests targeting updated packages are updated and passing.

---

### 03-fix-api-breaking-changes: Address API and behavioral changes

Fix code that fails to compile or behaves differently due to framework/SDK changes. Apply recommended code changes for API replacements or behavioral adjustments.

**Done when**: Solution builds, key runtime behaviors validated, and unit/integration tests pass.

---

### 04-run-tests-and-verify: Run tests and final verification

Run unit and integration tests, fix failing tests, and perform a final solution build and verification of warnings.

**Done when**: All tests pass and the solution builds warning-free.

---
