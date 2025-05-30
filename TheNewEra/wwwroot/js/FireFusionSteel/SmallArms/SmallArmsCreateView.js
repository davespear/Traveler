class SmallArmsCreateView {
    constructor() {
        this.app = document.getElementById('app');
        this.typeDropdown = document.createElement('select');
        this.typeModifierDropdown = document.createElement('select');
        this.tlModifierDropdown = document.createElement('select');
        this.cartridgeTypeModifierDropdown = document.createElement('select');
        this.specialModifierDropdown = document.createElement('select');

        this.app.append(this.typeDropdown,
            this.typeModifierDropdown,
            this.tlModifierDropdown,
            this.cartridgeTypeModifierDropdown,
            this.specialModifierDropdown
        );
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

    renderAmmoTypeModifierDropdown(options) {
        this.renderDropdown(this.typeModifierDropdown, options);
    }

    renderAmmoTLModifierDropdown(options) {
        this.renderDropdown(this.tlModifierDropdown, options);
    }

    renderAmmoCartridgeTypeModifierDropdown(options) {
        this.renderDropdown(this.cartridgeTypeModifierDropdown, options);
    }

    renderAmmoSpecialModifierDropdown(options) {
        this.renderDropdown(this.specialModifierDropdown, options);
    }

    setTypeModifierDropdownValueByText(text) {
        for (let i = 0; i < this.typeModifierDropdown.options.length; i++) {
            if (this.typeModifierDropdown.options[i].text === text) {
                this.typeModifierDropdown.selectedIndex = i;
                break;
            }
        }
    }

    setTypeModifierDropdownDisabled(disabled) {
        this.typeModifierDropdown.disabled = disabled;
    }
}