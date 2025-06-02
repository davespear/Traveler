class SmallArmsCreateView {
    constructor() {
        this.app = document.getElementById('app');

        // Create containers for each dropdown + label
        this.typeContainer = document.createElement('div');
        this.typeLabel = document.createElement('label');
        this.typeLabel.textContent = 'Cartridge Type:';
        this.typeLabel.htmlFor = 'ammoTypeDropdown';
        this.typeDropdown = document.createElement('select');
        this.typeDropdown.id = 'ammoTypeDropdown';
        this.typeContainer.append(this.typeLabel, this.typeDropdown);

        this.typeManufacturingModifierContainer = document.createElement('div');
        this.typeManufacturingModifierLabel = document.createElement('label');
        this.typeManufacturingModifierLabel.textContent = 'Manufacturing Method:';
        this.typeManufacturingModifierLabel.htmlFor = 'ammoManufacturingModifierDropdown';
        this.typeManufacturingModifierDropdown = document.createElement('select');
        this.typeManufacturingModifierDropdown.id = 'ammoManufacturingModifierDropdown';
        this.typeManufacturingModifierContainer.append(this.typeManufacturingModifierLabel, this.typeManufacturingModifierDropdown);

        this.tlModifierContainer = document.createElement('div');
        this.tlModifierLabel = document.createElement('label');
        this.tlModifierLabel.textContent = 'Tech Level:';
        this.tlModifierLabel.htmlFor = 'ammoTLModifierDropdown';
        this.tlModifierDropdown = document.createElement('select');
        this.tlModifierDropdown.id = 'ammoTLModifierDropdown';
        this.tlModifierContainer.append(this.tlModifierLabel, this.tlModifierDropdown);

        this.specialModifierContainer = document.createElement('div');
        this.specialModifierLabel = document.createElement('label');
        this.specialModifierLabel.textContent = 'Special Ammunition:';
        this.specialModifierLabel.htmlFor = 'ammoSpecialModifierDropdown';
        this.specialModifierDropdown = document.createElement('select');
        this.specialModifierDropdown.id = 'ammoSpecialModifierDropdown';
        this.specialModifierContainer.append(this.specialModifierLabel, this.specialModifierDropdown);

        // Append all containers to the app
        this.app.append(
            this.typeContainer,
            this.typeManufacturingModifierContainer,
            this.tlModifierContainer,
            this.specialModifierContainer
        );

      /*  this.app = document.getElementById('app');
        this.typeDropdown = document.createElement('select');
        this.typeManufacturingModifierDropdown = document.createElement('select');
        this.tlModifierDropdown = document.createElement('select');
        this.specialModifierDropdown = document.createElement('select');

        this.app.append(
            this.typeDropdown,
            this.typeManufacturingModifierDropdown,
            this.tlModifierDropdown,
            this.specialModifierDropdown
        );*/
    }

    renderDropdown(dropdown, options) {
        dropdown.innerHTML = '';
        options.forEach(opt => {
            const option = document.createElement('option');
            option.value = opt.id;
            option.textContent = opt.text;
            dropdown.appendChild(option);
        });
    }

    renderAmmoTypeDropdown(options) {
        this.renderDropdown(this.typeDropdown, options);
    }

    renderAmmoTLModifierDropdown(options) {
        this.renderDropdown(this.tlModifierDropdown, options);
    }

    renderAmmoManufacturingModifierDropdown(options) {
        this.renderDropdown(this.typeManufacturingModifierDropdown, options);
    }

    renderAmmoSpecialModifierDropdown(options) {
        this.renderDropdown(this.specialModifierDropdown, options);
    }

    setTypeModifierDropdownValueByText(text) {
        for (let i = 0; i < this.typeManufacturingModifierDropdown.options.length; i++) {
            if (this.typeManufacturingModifierDropdown.options[i].text === text) {
                this.typeManufacturingModifierDropdown.selectedIndex = i;
                break;
            }
        }
    }

    setTypeModifierDropdownDisabled(disabled) {
        this.typeManufacturingModifierDropdown.disabled = disabled;
    }
}