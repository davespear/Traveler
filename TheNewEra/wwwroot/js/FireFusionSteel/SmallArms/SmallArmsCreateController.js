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
            ammoCartridgeTypeModifiers,
            ammoSpecialModifiers
        ] = await Promise.all([
            SmallArmsServer.getAmmoTypes(),
            SmallArmsServer.getAmmoTypeModifiers(),
            SmallArmsServer.getAmmoTLModifiers(),
            SmallArmsServer.getAmmoCartridgeTypeModifiers(),
            SmallArmsServer.getAmmoSpecialModifiers()
        ]);
        this.model.setAmmoTypeDropdownData(ammoTypes);
        this.model.setAmmoTypeModifierDropdownData(ammoTypeModifiers);
        this.model.setAmmoTlModifierDropdownData(ammoTLModifiers);
        this.model.setAmmoCartridgeTypeModifierDropdownData(ammoCartridgeTypeModifiers);
        this.model.setAmmoSpecialModifierDropdownData(ammoSpecialModifiers);
        this.view.renderAmmoTypeDropdown(ammoTypes);
        this.view.renderAmmoTypeModifierDropdown(ammoTypeModifiers);
        this.view.renderAmmoTLModifierDropdown(ammoTLModifiers);
        this.view.renderAmmoCartridgeTypeModifierDropdown(ammoCartridgeTypeModifiers);
        this.view.renderAmmoSpecialModifierDropdown(ammoSpecialModifiers);
        this.view.typeDropdown.addEventListener('change', () => this.onTypeDropdownChange());
        this.onTypeDropdownChange();
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
}