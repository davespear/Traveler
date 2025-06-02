class SmallArmsCreateModel {
    constructor() {
        this.data = [];
        this.listeners = [];
        this.typeDropdownData = [];
        this.ammoManufacturingModifierDropdownData = [];
        this.tlModifierDropdownData = [];
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

    getAmmoManufacturingModifierDropdownData() {
        return this.ammoManufacturingModifierDropdownData;
    }

    getAmmoTLModifierDropdownData() {
        return this.tlModifierDropdownData;
    }

    getAmmoSpecialModifierDropdownData() {
        return this.specialModifierDropdownData;
    }

    setAmmoTypeDropdownData(data) {
        this.typeDropdownData = data;
    }

    setAmmoManufacturingModifierDropdownData(data) {
        this.ammoManufacturingModifierDropdownData = data;
    }

    setAmmoTlModifierDropdownData(data) {
        this.tlModifierDropdownData = data;
    }

    setAmmoSpecialModifierDropdownData(data) {
        this.specialModifierDropdownData = data;
    }
}