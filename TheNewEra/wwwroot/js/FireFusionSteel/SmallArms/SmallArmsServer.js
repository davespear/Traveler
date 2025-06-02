// Handles communication with the FireFusionSteel controller for small arms
const SmallArmsServer = {
    fetchDropdown: async function (url) {
        const response = await fetch(url);
        return await response.json();
    },
    getAmmoTypes: async function () {
        return await this.fetchDropdown('/FireFusionSteel/GetSmallArmsAmmoTypes');
    },
    getAmmoManufacturingModifiers: async function () {
        return await this.fetchDropdown('/FireFusionSteel/GetSmallArmsAmmoManufacturingModifiers');
    },
    getAmmoTLModifiers: async function () {
        return await this.fetchDropdown('/FireFusionSteel/GetSmallArmsAmmoTLTypeModifiers');
    },

    getAmmoSpecialModifiers: async function () {
        return await this.fetchDropdown('/FireFusionSteel/GetSmallArmsAmmoSpecialModifiers');
    }
};