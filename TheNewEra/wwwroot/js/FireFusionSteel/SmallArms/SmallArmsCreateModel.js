class SmallArmsCreateModel {
    constructor() {
        this.data = [];
        this.listeners = [];
        this.typeDropdownData = [];
        this.typeModifierDropdownData = [];
        this.tlModifierDropdownData = [];
        this.cartridgeTypeModifierDropdownData = [];
        this.specialModifierDropdownData = [];
    }

    addItem(item) {
        this.data.push(item);
        this.notify();
    }

    removeItem(index) {
        this.data.splice(index, 1);
        this.notify();
    }

    onChange(listener) {
        this.listeners.push(listener);
    }

    notify() {
        this.listeners.forEach((listener) => listener(this.data));
    }

    getAmmoTypeDropdownData() {
        return this.typeDropdownData;
    }

    getAmmoTypeModifierDropdownData() {
        return this.typeModifierDropdownData;
    }

    getAmmoTLModifierDropdownData() {
        return this.tlModifierDropdownData;
    }

    getAmmoCartridgeTypeModifierDropdownData() {
        return this.getCartridgeTypeModifierDropdownData;
    }

    getAmmoSpecialModifierDropdownData() {
        return this.specialModifierDropdownData;
    }

    setAmmoTypeDropdownData(data) {
        this.typeDropdownData = data;
    }

    setAmmoTypeModifierDropdownData(data) {
        this.typeModifierDropdownData = data;
    }

    setAmmoTlModifierDropdownData(data) {
        this.tlModifierDropdownData = data;
    }

    setAmmoCartridgeTypeModifierDropdownData(data) {
        this.cartridgeTypeDropdownData = data;
    }

    setAmmoSpecialModifierDropdownData(data) {
        this.specialModifierDropdownData = data;
    }
}