CREATE TRIGGER `capture_stats_number_command_to_ship` BEFORE UPDATE ON `commande`
    FOR EACH ROW IF (NEW.estPayee = 1) THEN
    UPDATE statistiques SET statistiques.value_stat = statistiques.value_stat + 1 WHERE statistiques.name_stat = "number_command_to_ship";
END IF;