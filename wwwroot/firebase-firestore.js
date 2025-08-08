window.firestoreInterop = {
    getUsuarios: async function () {
        const snapshot = await db.collection("usuarios").get();
        return snapshot.docs.map(doc => doc.data());
    },

    getUltimoIdEmpleado: async function () {
        const snapshot = await db.collection("usuarios")
            .orderBy("Id_Empleado", "desc")
            .limit(1)
            .get();

        if (snapshot.empty) return 1;
        return snapshot.docs[0].data().Id_Empleado + 1;
    },

    addUsuario: async function (usuario) {
        return db.collection("usuarios").add(usuario)
            .then(() => "OK")
            .catch(err => err.message);
    }
};