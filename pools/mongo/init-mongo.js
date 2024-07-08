db.createUser({
	user: 'mernuser',
	pwd: 'mernpassword',
	roles: [
		{
			role: 'readWrite',
			db: 'merndb',
		},
	],
});

db.createCollection('testCollection');
