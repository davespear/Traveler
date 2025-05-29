// Handles communication with the FireFusionSteel controller for small arms
const SmallArmsServer = {
    getAmmoTypes: async function () {
        const response = await fetch('/FireFusionSteel/GetSmallArmsAmmoTypes');
        return await response.json();
    },
    getAmmoTypeModifiers: async function () {
        const response = await fetch('/FireFusionSteel/GetSmallArmsAmmoTypeModifiers');
        return await response.json();
    },
    getAmmoTLModifiers: async function () {
        const response = await fetch('/FireFusionSteel/GetSmallArmsAmmoTLTypeModifiers');
        return await response.json();
    },
    getAmmoCartridgeTypeModifiers: async function () {
        const response = await fetch('/FireFusionSteel/GetSmallArmsAmmoCartridgeTypeModifiers');
        return await response.json();
    },
    getAmmoSpecialModifiers: async function () {
        const response = await fetch('/FireFusionSteel/GetSmallArmsAmmoSpecialModifiers');
        return await response.json();
    }
};