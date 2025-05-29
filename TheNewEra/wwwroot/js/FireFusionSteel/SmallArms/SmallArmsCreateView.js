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

    renderAmmoTypeDropdown(options) {
        this.typeDropdown.innerHTML = '';
        options.forEach(opt => {
            const option = document.createElement('option');
            option.value = opt.id;
            option.textContent = opt.text;
            this.typeDropdown.appendChild(option);
        });
    }

    renderAmmoTypeModifierDropdown(options) {
        this.typeModifierDropdown.innerHTML = '';
        options.forEach(opt => {
            const option = document.createElement('option');
            option.value = opt.id;
            option.textContent = opt.text;
            this.typeModifierDropdown.appendChild(option);
        });
    }

    renderAmmoTLModifierDropdown(options) {
        this.tlModifierDropdown.innerHTML = '';
        options.forEach(opt => {
            const option = document.createElement('option');
            option.value = opt.id;
            option.textContent = opt.text;
            this.tlModifierDropdown.appendChild(option);
        });
    }

    renderAmmoCartridgeTypeModifierDropdown(options) {
        this.cartridgeTypeModifierDropdown.innerHTML = '';
        options.forEach(opt => {
            const option = document.createElement('option');
            option.value = opt.id;
            option.textContent = opt.text;
            this.cartridgeTypeModifierDropdown.appendChild(option);
        });
    }

    renderAmmoSpecialModifierDropdown(options) {
        this.specialModifierDropdown.innerHTML = '';
        options.forEach(opt => {
            const option = document.createElement('option');
            option.value = opt.id;
            option.textContent = opt.text;
            this.specialModifierDropdown.appendChild(option);
        });
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