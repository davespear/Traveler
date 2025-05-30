// Handles communication with the FireFusionSteel controller for small arms
const SmallArmsServer = {
    fetchDropdown: async function (url) {
        const response = await fetch(url);
        return await response.json();
    },
    getAmmoTypes: async function () {
        return await this.fetchDropdown('/FireFusionSteel/GetSmallArmsAmmoTypes');
    },
    getAmmoTypeModifiers: async function () {
        return await this.fetchDropdown('/FireFusionSteel/GetSmallArmsAmmoTypeModifiers');
    },
    getAmmoTLModifiers: async function () {
        return await this.fetchDropdown('/FireFusionSteel/GetSmallArmsAmmoTLTypeModifiers');
    },
    getAmmoCartridgeTypeModifiers: async function () {
        return await this.fetchDropdown('/FireFusionSteel/GetSmallArmsAmmoCartridgeTypeModifiers');
    },
    getAmmoSpecialModifiers: async function () {
        return await this.fetchDropdown('/FireFusionSteel/GetSmallArmsAmmoSpecialModifiers');
    }
};