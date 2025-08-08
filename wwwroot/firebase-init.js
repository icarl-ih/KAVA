
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
    apiKey: "AIzaSyCeFFDCjpHJZUQfV0y0LgIlTKEByAqYwmo",
    authDomain: "kava-d52c5.firebaseapp.com",
    projectId: "kava-d52c5",
    storageBucket: "kava-d52c5.firebasestorage.app",
    messagingSenderId: "984784531211",
    appId: "1:984784531211:web:44973e263ca792f64c3c0e",
    measurementId: "G-K0T14PB4GL"
};
firebase.initializeApp(firebaseConfig);
const db = firebase.firestore();

window.firestoreInterop = {
    addUsuario: function (usuario) {
        return db.collection("Usuarios").add(usuario)
            .then(() => "OK")
            .catch(err => err.message);
    }, getUsuarios: function () {
        return db.collection("Usuarios").get()
            .then(snapshot => {
                const lista = [];
                snapshot.forEach(doc => {
                    const data = doc.data();
                    data.id = doc.id;
                    lista.push(data);
                });
                return lista;
            })
            .catch(err => { throw err.message; });
    }

};

