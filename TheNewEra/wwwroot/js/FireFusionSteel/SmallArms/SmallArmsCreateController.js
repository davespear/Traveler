class SmallArmsCreateController {
    constructor(model, view) {
        this.model = model;
        this.view = view;

        this.initializeDropdowns();
    }

    async initializeDropdowns() {
        const [
            ammoTypes,
            ammoTypeModifiers,
            ammoTLModifiers,
            ammoSpecialModifiers
        ] = await Promise.all([
            SmallArmsServer.getAmmoTypes(),
            SmallArmsServer.getAmmoManufacturingModifiers(),
            SmallArmsServer.getAmmoTLModifiers(),
            SmallArmsServer.getAmmoSpecialModifiers()
        ]);
        this.setModelDropdowns(ammoTypes, ammoTLModifiers, ammoTypeModifiers, ammoSpecialModifiers)
        this.setViewDropdowns(ammoTypes, ammoTLModifiers, ammoTypeModifiers, ammoSpecialModifiers)
        this.presetDropdowns();
        this.addEventListeners();
        this.onTypeDropdownChange();
    }

    setModelDropdowns(ammoTypes, ammoTLModifiers, ammoTypeModifiers, ammoSpecialModifiers) {
        this.model.setAmmoTypeDropdownData(ammoTypes);
        this.model.setAmmoTlModifierDropdownData(ammoTLModifiers);
        this.model.setAmmoManufacturingModifierDropdownData(ammoTypeModifiers);
        this.model.setAmmoSpecialModifierDropdownData(ammoSpecialModifiers);
    }

    setViewDropdowns(ammoTypes, ammoTLModifiers, ammoTypeModifiers, ammoSpecialModifiers) {
        this.view.renderAmmoTypeDropdown(ammoTypes);
        this.view.renderAmmoTLModifierDropdown(ammoTLModifiers);
        this.view.renderAmmoManufacturingModifierDropdown(ammoTypeModifiers);
        this.view.renderAmmoSpecialModifierDropdown(ammoSpecialModifiers);
    }

    onTypeDropdownChange() {
        const selectedTypeText = this.view.typeDropdown.options[this.view.typeDropdown.selectedIndex].text;
        if (selectedTypeText === "Shotgun") {
            this.view.setTypeModifierDropdownValueByText("Shotgun");
            this.view.setTypeModifierDropdownDisabled(true);
        } else {
            this.view.setTypeModifierDropdownDisabled(false);
        }
    }

    addEventListeners() {
        this.view.typeDropdown.addEventListener('change', () => {
            const selectedTypeText = this.view.typeDropdown.options[this.view.typeDropdown.selectedIndex].text;
            const allManufacturingOptions = this.model.getAmmoManufacturingModifierDropdownData();

            if (selectedTypeText === "Shotgun") {
                // Only show "Shotgun" and disable
                const shotgunOption = allManufacturingOptions.filter(opt => opt.text === "Shotgun");
                this.view.renderAmmoManufacturingModifierDropdown(shotgunOption);
                this.view.setTypeModifierDropdownValueByText("Shotgun");
                this.view.setTypeModifierDropdownDisabled(true);
            } else {
                // Show all except "Shotgun" and enable
                const filteredOptions = allManufacturingOptions.filter(opt => opt.text !== "Shotgun");
                this.view.renderAmmoManufacturingModifierDropdown(filteredOptions);
                this.view.setTypeModifierDropdownDisabled(false);
            }
        });
    }

    presetDropdowns() {
        const selectedTypeText = this.view.typeDropdown.options[this.view.typeDropdown.selectedIndex].text;
        const allManufacturingOptions = this.model.getAmmoManufacturingModifierDropdownData();

        if (selectedTypeText === "Shotgun") {
            const shotgunOption = allManufacturingOptions.filter(opt => opt.text === "Shotgun");
            this.view.renderAmmoManufacturingModifierDropdown(shotgunOption);
            this.view.setTypeModifierDropdownValueByText("Shotgun");
            this.view.setTypeModifierDropdownDisabled(true);
        } else {
            const filteredOptions = allManufacturingOptions.filter(opt => opt.text !== "Shotgun");
            this.view.renderAmmoManufacturingModifierDropdown(filteredOptions);
            this.view.setTypeModifierDropdownDisabled(false);
        }
    }
}